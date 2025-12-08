using System;
using System.Linq;

namespace DevExpress.AI.WinForms.AIGeneratePalette.UI {
    /// <summary>
    /// History entry that pairs the user's original prompt with the corresponding AI response.
    /// </summary>
    public record class GeneratePaletteHistoryItem(string UserPrompt, GeneratePaletteResponse Response) { }
}
