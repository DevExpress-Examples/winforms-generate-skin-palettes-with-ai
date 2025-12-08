using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.AI.WinForms.AIGeneratePalette.Helpers; // for GeneratePaletteResponseHelpers

namespace DevExpress.AI.WinForms.AIGeneratePalette.Persistence {
    /// <summary>
    /// Stores a persisted AI-generated palette. Maintains backward compatibility with the previous JSON schema.
    /// Includes the raw AI textual response. Enables precise reconstruction in future sessions.
    /// </summary>
    public sealed class AIPaletteEntry {
        [JsonPropertyName("AIPaletteResponse")] public string AIPaletteResponse { get; set; } = string.Empty;
        [JsonPropertyName("ReferencePaletteName")] public string ReferencePaletteName { get; set; } = string.Empty;
        [JsonPropertyName("SkinName")] public string SkinName { get; set; } = string.Empty;
        [JsonPropertyName("AIPaletteName")] public string AIPaletteName { get; set; } = string.Empty;

        public AIPaletteEntry() { }
        /// <summary>
        /// Construct an entry with metadata to recreate the palette.
        /// </summary>
        public AIPaletteEntry(string response, string referencePaletteName, string skinName, string displayName) {
            AIPaletteResponse = response ?? string.Empty;
            ReferencePaletteName = referencePaletteName ?? string.Empty;
            SkinName = skinName ?? string.Empty;
            AIPaletteName = displayName ?? string.Empty;
        }
    }

    public sealed class AIPaletteRepositoryData {
        [JsonPropertyName("CustomPalettes")] public List<AIPaletteEntry> Palettes { get; set; } = new();
    }

    /// <summary>
    /// Repository that handles persistence. Replaces the older singleton style.
    /// Holds a Default instance, which can serialize and deserialize from application settings.
    /// </summary>
    public static class AIPaletteRepository {
        /// <summary>
        /// In-memory store loaded from user settings. Can be replaced, for example, when reloading from updated JSON.
        /// </summary>
        public static AIPaletteRepositoryData Default { get; private set; }

        static AIPaletteRepository() {
            Default = new AIPaletteRepositoryData();
        }

        /// <summary>
        /// Serialize the current repository data to JSON. Never throws; returns valid JSON even if Default is null.
        /// </summary>
        public static string SaveToJson() {
            return JsonSerializer.Serialize(Default ?? new AIPaletteRepositoryData());
        }

        /// <summary>
        /// Internal loader that replaces Default with data from JSON or with a new empty store on error.
        /// </summary>
        static void LoadDefault(string json) {
            try {
                if(!string.IsNullOrWhiteSpace(json)) {
                    var data = JsonSerializer.Deserialize<AIPaletteRepositoryData>(json);
                    Default = data ?? new AIPaletteRepositoryData();
                }
                else
                    Default = new AIPaletteRepositoryData();
            }
            catch {
                // Corrupted JSON. Start with a fresh store. Silent for simplicity.
                Default = new AIPaletteRepositoryData();
            }
        }

        /// <summary>
        /// Load previously saved AI palettes. Reconstruct them as custom palettes within their respective skins.
        /// </summary>
        /// <param name="json">Serialized repository JSON.</param>
        /// <param name="loadCustomPalettes">If false, load only metadata without adding palettes to DevExpress skins.</param>
        public static void LoadAIPalettes(string json, bool loadCustomPalettes = true) {
            LoadDefault(json);
            if(!loadCustomPalettes)
                return;
            foreach(var entry in Default.Palettes) {
                var commonSkin = CommonSkins.GetSkin(SkinProviderHelper.GetSkinProvider(entry.SkinName));
                if(commonSkin == null)
                    continue; // Skin might no longer be available
                SvgPalette referencePalette = commonSkin.SvgPalettes[Skin.DefaultSkinPaletteName];
                if(!string.IsNullOrEmpty(entry.ReferencePaletteName) && commonSkin.CustomSvgPalettes[entry.ReferencePaletteName] != null) {
                    referencePalette = commonSkin.CustomSvgPalettes[entry.ReferencePaletteName];
                }
                SvgPalette aiPalette = GeneratePaletteResponseHelpers.CreatePaletteFromResponseString(entry.AIPaletteResponse, referencePalette, out string unusedHere);
                if(!commonSkin.CustomSvgPalettes.Any(p => p.Key.Name == entry.AIPaletteName)) {
                    commonSkin.CustomSvgPalettes.Add(new SvgPaletteKey(commonSkin.CustomSvgPalettes.Count, entry.AIPaletteName), aiPalette);
                }
            }
        }
    }
}
