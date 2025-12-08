using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.AI.WinForms.AIGeneratePalette.Persistence;
using DevExpress.AIIntegration;
using DevExpress.LookAndFeel;
using DevExpress.Mvvm.POCO;
using DevExpress.Office.History;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.WinForms.AIGeneratePalette.UI {
    /// <summary>
    /// MVVM ViewModel for GeneratePaletteDialog. Handles user prompts, async palette generation, history navigation,
    /// and applies selected palettes to the active DevExpress LookAndFeel.
    /// </summary>
    public class GeneratePaletteUIViewModel {
        // History of generations. Linear and truncated when a new branch starts after mid-history generation.
        readonly List<GeneratePaletteHistoryItem> Items = new();
        CancellationTokenSource cts; // Cancels in-flight AI generation

        string inputPrompt;
        /// <summary>
        /// User input prompt bound to the chat textbox. Triggers re-evaluation of CanGenerate.
        /// </summary>
        public string InputPrompt {
            get => inputPrompt;
            set {
                if(inputPrompt == value)
                    return;
                inputPrompt = value;
                this.RaiseCanExecuteChanged(x => x.Generate());
                this.RaisePropertyChanged(x => x.InputPrompt);
            }
        }

        bool isGenerating = false;
        /// <summary>
        /// True while an AI request is in progress. Disables generation to prevent duplicate calls.
        /// </summary>
        public bool IsGenerating {
            get => isGenerating; 
            set {
                if(isGenerating == value)
                    return;
                isGenerating = value;
                this.RaiseCanExecuteChanged(x => x.Generate());
                this.RaisePropertyChanged(x=>x.IsGenerating);
            }
        }

        int currentIndex = -1;
        /// <summary>
        /// Index of the currently selected history item. -1 if none is selected.
        /// </summary>
        public virtual int CurrentIndex {
            get => currentIndex;
            set {
                if(currentIndex == value)
                    return;
                currentIndex = value;
                this.RaiseCanExecuteChanged(x => x.Reset());
                this.RaiseCanExecuteChanged(x => x.Save());
                this.RaisePropertyChanged(x => x.CurrentIndex);
                this.RaisePropertyChanged(x => x.CurrentPalette);
            }
        }

        /// <summary>
        /// Selected history entry. Null if none is selected.
        /// </summary>
        public GeneratePaletteHistoryItem Current => CurrentIndex < 0 || CurrentIndex >= Items.Count ? null : Items[CurrentIndex];
        /// <summary>
        /// Palette of the current history entry. Serves as a binding shortcut.
        /// </summary>
        public SvgPalette CurrentPalette => Current?.Response?.Result;

        protected bool CanSave() { return CurrentPalette != null; }
        protected bool CanReset() { return Items.Count > 0; }
        protected bool CanGenerate() { return !string.IsNullOrWhiteSpace(InputPrompt) && !IsGenerating; }

        /// <summary>
        /// Adds a new history item and trims any redo branch beyond the current index.
        /// </summary>
        void Add(string userPrompt, GeneratePaletteResponse response) {
            for(int i = Items.Count - 1; i > CurrentIndex; i--)
                Items.RemoveAt(i); // clear redo items after branching
            Items.Add(new GeneratePaletteHistoryItem(userPrompt, response));
            CurrentIndex = Items.Count - 1;
        }

        /// <summary>
        /// Clear all history and reset the selection.
        /// </summary>
        public void Reset() {
            Items.Clear();
            CurrentIndex = -1;
        }

        /// <summary>
        /// Apply the selected palette to the active skin and persist metadata using AIPaletteRepository.
        /// </summary>
        public void Save() {
            if(!CanSave()) return;
            var current = Current;
            if(current == null || current.Response == null || current.Response.Result == null)
                return;
            var commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            const string aiPaletteNameBase = "AI Custom Palette";
            string aiPaletteName = aiPaletteNameBase;
            int counter = 1;
            // Ensure the display name is unique.
            while (commonSkin.CustomSvgPalettes.Any(p => p.Key.Name == aiPaletteName)) {
                aiPaletteName = $"{aiPaletteNameBase} ({counter++})";
            }

            // Persist the original AI textual response.
            AIPaletteRepository.Default.Palettes.Add(new AIPaletteEntry(current.Response.Response, UserLookAndFeel.Default.ActiveSvgPaletteName, commonSkin.Name, aiPaletteName));
            commonSkin.CustomSvgPalettes.Add(new SvgPaletteKey(commonSkin.CustomSvgPalettes.Count, aiPaletteName), current.Response.Result);
            UserLookAndFeel.Default.SetSkinStyle(commonSkin.Name, aiPaletteName);
        }

        /// <summary>
        /// Start an async generation using the current InputPrompt and conversation history.
        /// </summary>
        public async Task Generate() {
            if(!CanGenerate()) return;
            IsGenerating = true;
            try {
                using(cts = new CancellationTokenSource()) {
                    var extension = (GeneratePaletteExtension)AIExtensionsContainerDesktop.Default.GetExtension(typeof(GeneratePaletteRequest));
                    var request = new GeneratePaletteRequest(InputPrompt, UserLookAndFeel.Default);
                    foreach(var msg in GetAIConversationMessages()) request.ConversationMessages.Add(msg);

                    var response = await extension.ExecuteAsync(request, cts.Token);
                    if(response != null && response.IsValid) {
                        Add(InputPrompt, response);
                        InputPrompt = string.Empty; // Triggers CanGenerate changed.
                    }
                }
            }
            catch(OperationCanceledException) { /* User cancelled */ }
            catch(Exception ex) {
                XtraMessageBox.Show(ex.Message, "Generation error. Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                cts = null;
                IsGenerating = false;
            }
        }

        /// <summary>
        /// Remove the specified message and all later entries from history. Adjust the selection accordingly.
        /// </summary>
        public void DeleteMessage(string messageContent) {
            int index = Items.FindIndex(item => item.UserPrompt == messageContent);
            if(index != -1) {
                for(int i = Items.Count - 1; i >= index; i--)
                    Items.RemoveAt(i);
                CurrentIndex = Items.Count - 1;
            }
        }

        /// <summary>
        /// Cancel any in-flight generation. No exception is thrown if the request is already complete.
        /// </summary>
        public void CancelGeneration() => cts?.Cancel();

        /// <summary>
        /// Replay chat history up to the current index (alternate user and assistant messages to provide context for the next generation).
        /// </summary>
        IEnumerable<AIConversationMessage> GetAIConversationMessages() {
            for(int i = 0; i < CurrentIndex + 1; i++) {
                yield return new AIConversationMessage(ChatRole.User, Items[i].UserPrompt);
                yield return new AIConversationMessage(ChatRole.Assistant, Items[i].Response.Response);
            }
        }
    }
}
