using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors.OtherDialogs.PaletteEditor;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Helpers {
    /// <summary>
    /// Utility methods used by the palette generation AI extension.
    ///  1. Load embedded system prompt instructions.
    ///  2. Parse AI textual responses into SvgPalette instances.
    ///  3. Produce a detailed textual description of an existing palette for model context.
    /// </summary>
    internal static class GeneratePaletteResponseHelpers {
        // Cached system prompt text, loaded once from the embedded resource.
        static string _generatePaletteSystemPrompt; // cached
        const string ResourceFileName = "GeneratePaletteInstruction.md"; // logical embedded resource file name

        /// <summary>
        /// System prompt loaded from an embedded markdown resource.
        /// Supplies deterministic instructions and expected output format to the AI model.
        /// </summary>
        public static string GeneratePaletteSystemPrompt {
            get {
                if(_generatePaletteSystemPrompt != null)
                    return _generatePaletteSystemPrompt;
                _generatePaletteSystemPrompt = LoadEmbedded(ResourceFileName) ?? string.Empty;
                return _generatePaletteSystemPrompt;
            }
        }

        /// <summary>
        /// Load an embedded resource by case-insensitive suffix and return its full text content.
        /// Return null if the resource is not found or an I/O error occurs.
        /// </summary>
        static string LoadEmbedded(string shortName) {
            try {
                var asm = Assembly.GetExecutingAssembly();
                // Resource names typically use Namespace.FileName. Locate by suffix to improve resilience.
                var name = asm.GetManifestResourceNames()
                              .FirstOrDefault(r => r.EndsWith("." + shortName, StringComparison.OrdinalIgnoreCase));
                if(name == null)
                    return null;
                using(var stream = asm.GetManifestResourceStream(name)) {
                    if(stream == null)
                        return null;
                    using(var reader = new StreamReader(stream))
                        return reader.ReadToEnd();
                }
            }
            catch { return null; }
        }

        // Shared ColorConverter instance to avoid repeated allocations during parsing.
        static readonly ColorConverter SharedColorConverter = new ColorConverter();

        /// <summary>
        /// Lenient parser compatible with earlier behavior. Attempts to parse and update colors.
        /// If parsing fails, returns a clone of the reference palette to maintain UI stability.
        /// Collects any explanation lines from non key:value entries.
        /// </summary>
        /// <param name="responseString">Raw AI response text.</param>
        /// <param name="currentPalette">Reference palette to clone and update.</param>
        /// <param name="paletteExplanation">Human-readable text extracted from lines that are not key:value pairs.</param>
        /// <returns>A palette instance (never null). Returns a clone of the original if parsing fails.</returns>
        public static SvgPalette CreatePaletteFromResponseString(string responseString, SvgPalette currentPalette, out string paletteExplanation) {
            if(currentPalette == null)
                throw new ArgumentNullException(nameof(currentPalette));
            TryCreatePaletteFromResponse(responseString, currentPalette, out var result, out paletteExplanation);
            return result ?? currentPalette.Clone();
        }

        /// <summary>
        /// Strict parser used in the generation workflow. Enforces:
        ///  * At least one valid color or gradient change.
        ///  * All color names exist in the reference palette.
        ///  * Gradient stop counts match.
        /// Returns false on any inconsistency (the caller can supply a user-friendly error).
        /// </summary>
        /// <param name="responseString">Raw AI textual output.</param>
        /// <param name="referencePalette">Palette used as the baseline for modifications.</param>
        /// <param name="newPalette">Resulting palette (null if parsing fails).</param>
        /// <param name="paletteExplanation">Collected non key:value lines, potentially containing an explanation from the model.</param>
        internal static bool TryCreatePaletteFromResponse(string responseString, SvgPalette referencePalette, out SvgPalette newPalette, out string paletteExplanation) {
            newPalette = null;
            paletteExplanation = string.Empty;
            if(referencePalette == null || string.IsNullOrWhiteSpace(responseString))
                return false;

            var lines = responseString.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if(lines.Length == 0)
                return false;

            // Map of colorName to value (the last occurrence takes precedence).
            Dictionary<string, string> map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach(var raw in lines) {
                int idx = raw.IndexOf(':');
                if(idx <= 0) {
                    // Treat lines without ':' as explanation or commentary.
                    paletteExplanation += raw + Environment.NewLine;
                    continue;
                }
                var name = raw.Substring(0, idx).Trim();
                var value = raw.Substring(idx + 1).Trim();
                if(name.Length == 0 || value.Length == 0)
                    continue;
                // Override duplicates.
                map[name] = value; 
            }

            if(map.Count == 0)
                return false;

            var referenceColorNames = referencePalette.Colors.Select(c => c.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);

            // Reject if any unknown color names are present (avoid silent typos creeping into saved palette).
            if(map.Any(x => !referenceColorNames.Contains(x.Key)))
                return false; // Reject if the map contains unknown color names.

            SvgPalette clone = referencePalette.Clone();
            int appliedChanges = 0;
            foreach(var keyValue in map) {
                try {
                    var svgColor = clone[keyValue.Key];
                    if(svgColor == null)
                        return false; // Inconsistent structure; reject the response.
                    string svgColorString = keyValue.Value;

                    // Gradient syntax: Gradient(Color1|Color2|...). Number of colors must match the original gradient stops.
                    if (svgColorString.StartsWith("Gradient(", StringComparison.OrdinalIgnoreCase) && svgColorString.EndsWith(")")) {
                        string inner = svgColorString.Substring(9, svgColorString.Length - 10);
                        var parts = inner.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
                        if(svgColor.Gradient == null || parts.Length != svgColor.Gradient.Stops.Count)
                            return false; // Reject the response due to gradient stop count mismatch.
                        for (int i = 0; i < svgColor.Gradient.Stops.Count; i++) {
                            SvgGradientStop original = svgColor.Gradient.Stops[i];
                            svgColor.Gradient.Stops[i] = SvgGradientStop.Create(original.Offset, parts[i], original.StopOpacity);
                        }
                        appliedChanges++;
                    }
                    else {
                        // Parse solid color (supports #RRGGBB and known color names)
                        var parsed = (Color)SharedColorConverter.ConvertFromString(svgColorString);
                        if(parsed != Color.Empty && parsed != svgColor.Value) {
                            svgColor.Value = parsed;
                            appliedChanges++;
                        }
                    }
                }
                catch {
                    return false; // Reject on any parsing error to allow the caller to retry or show feedback.
                }
            }
            if(appliedChanges == 0)
                return false; // No effective changes; treat as invalid to avoid saving a redundant palette.
            newPalette = clone;
            return true;
        }

        /// <summary>
        /// Build a detailed textual description of the palette. Group colors by category and include
        /// descriptive metadata (caption and description). This information is fed to the model to improve semantic grounding.
        /// </summary>
        /// <param name="palette">Palette to describe.</param>
        /// <param name="skinProvider">Skin provider used to resolve palette description metadata.</param>
        /// <returns>Markdown-based structured description. May be empty.</returns>
        public static string GetPaletteDescription(SvgPalette palette, ISkinProvider skinProvider) {
            var paletteDescription = SvgPaletteDescription.GetPaletteDescription(skinProvider.SkinName);
            if(paletteDescription == null)
                return string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            List<SvgColorEntry> colorsWithDescriptions = new List<SvgColorEntry>();
            foreach(SvgColor color in palette.Colors) {
                if(string.IsNullOrWhiteSpace(color.Name))
                    continue;
                SvgColorCategory category = new SvgColorCategory(paletteDescription.GetCategoryIndex(color.Name), paletteDescription.GetCategoryCaption(color.Name), paletteDescription.GetCategoryDescription(color.Name));
                string colorDescription = paletteDescription.GetColorDescription(color.Name);
                colorsWithDescriptions.Add(new SvgColorEntry(color, color.Name, colorDescription, category));
            }
            stringBuilder.AppendLine("# Default Palette:");
            var groupBy = colorsWithDescriptions.GroupBy(x => x.CategoryID);
            foreach(var group in groupBy) {
                string currentGroupLine = string.Empty;
                foreach(var color in group) {
                    if(string.IsNullOrEmpty(currentGroupLine)) {
                        currentGroupLine = $"# {color.Category.Caption} ({color.Category.Description})";
                        stringBuilder.AppendLine(currentGroupLine);
                    }
                    if(color.SvgColor.Gradient != null) {
                        // Serialize gradient stops in a deterministic format: Color1|Color2|... Include stop offsets.
                        string colorGradient = String.Join("|", color.SvgColor.Gradient.Stops.Select(x => x.StopColor));
                        string colorGradientStops = "Offsets: " + String.Join(";", color.SvgColor.Gradient.Stops.Select(x => x.StopColor + $"={x.Offset}"));
                        stringBuilder.AppendLine($"{color.Name}:Gradient({colorGradient}) ({color.Description} {colorGradientStops})");
                    }
                    else {
                        string hex = $"#{color.Value.R:X2}{color.Value.G:X2}{color.Value.B:X2}";
                        stringBuilder.AppendLine($"{color.Name}:{hex} ({color.Description})");
                    }
                }
            }
            if(palette.Colors != palette.OriginalColors) {
                // Include current palette override values if they differ from the original, excluding descriptions.
                stringBuilder.AppendLine("# Current Palette without description:");
                foreach(SvgColor color in palette.Colors) {
                    if(string.IsNullOrWhiteSpace(color.Name) || color.Value == Color.Empty)
                        continue;
                    if(color.Gradient != null) {
                        string colorGradient = String.Join("|", color.Gradient.Stops.Select(x => x.StopColor));
                        stringBuilder.AppendLine($"{color.Name}:Gradient({colorGradient})");
                    }
                    else {
                        string hex = $"#{color.Value.R:X2}{color.Value.G:X2}{color.Value.B:X2}";
                        stringBuilder.AppendLine($"{color.Name}:{hex}");
                    }
                }
            }
            return stringBuilder.ToString();
        }
    }
}