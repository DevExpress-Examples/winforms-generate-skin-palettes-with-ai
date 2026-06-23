using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using DevExpress.AI.WinForms.AIGeneratePalette.Persistence;
using DevExpress.AIIntegration;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.MVVM.Internal;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.AI.Native;
using Microsoft.Extensions.AI;
using DevExpress.AIIntegration.Blazor.Chat;
using Microsoft.AspNetCore.Components;
using System.Windows.Markup;
using DevExpress.AIIntegration.Blazor.Chat.WebView;
using DevExpress.Utils.Svg.Extensions;

namespace DevExpress.AI.WinForms.AIGeneratePalette.UI {
    /// <summary>
    /// The Generate Palette dialog allows users to enter natural language prompts, preview AI generated palettes,
    /// and save them as custom DevExpress SVG palettes.
    /// Combines WinForms controls with an embedded Blazor-based chat component.
    /// </summary>
    public partial class GeneratePaletteDialog : DevExpress.XtraEditors.XtraForm {
        AIOverlayForm overlayForm; // Simple overlay used to show a busy/loading indication during generation
        public GeneratePaletteDialog() {
            InitializeComponent();
            InitPreview();

            var fluent = mvvmContext1.OfType<GeneratePaletteUIViewModel>();

            fluent.BindCommand(saveSimpleButton, x => x.Save());
            fluent.BindCommand(resetSimpleButton, x => x.Reset());

            // Preview update on palette change.
            fluent.SetTrigger(x => x.CurrentPalette, CurrentPaletteChanged);

            fluent.SetTrigger(x => x.IsGenerating, OnIsGeneratingChanged);

            // Customize the message template to display the Delete button within messages.
            aiChatControl1.SetMessageContentTemplate(message => builder => {
                builder.OpenComponent<MessageTemplate>(0);
                builder.AddAttribute(1, nameof(MessageTemplate.Message), message);
                builder.AddAttribute(2, nameof(MessageTemplate.OnDeleteButtonClick), EventCallback.Factory.Create<string>(this, OnDeleteMessageClick));
                builder.CloseComponent();
            });

            // Display prompt suggestions.
            aiChatControl1.SetPromptSuggestions(new List<PromptSuggestion>() {
                new PromptSuggestion(
                    "The Trendiest",
                    "The trendiest and most sought-after theme for 2026.",
                    "Generate the trendiest and most sought-after theme for 2026."),
                new PromptSuggestion(
                    "DevExpress",
                    "DevExpress corporate palette using signature orange with complementary neutrals.",
                    "Generate a cohesive application palette inspired by DevExpress brand styling."),
                new PromptSuggestion(
                    "Cyberpunk Dark",
                    "Dark cyberpunk palette: layered charcoals + neon cyan / magenta / amber accents.",
                    "Design a dark cyberpunk style palette: deep layered charcoals and carbon blacks for backgrounds, gentle mid-tone panels for readable contrast, and restrained luminous neon accents (cyan, magenta, amber) for interactive highlights and emphasis. Ensure sufficient contrast for text, provide subtle hover/pressed states, and deliver accessible semantic colors that feel integrated with the futuristic theme without causing eye strain.")
            });
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CurrentPaletteChanged(null);
        }

        void OnDeleteMessageClick(string messageContent) {
            var viewModel = mvvmContext1.GetViewModel<GeneratePaletteUIViewModel>();
            viewModel.DeleteMessage(messageContent);
            IEnumerable<BlazorChatMessage> saveMessages = aiChatControl1.SaveMessages();
            List<BlazorChatMessage> list = saveMessages.ToList();
            int index = list.FindIndex(x => x.Text == messageContent);
            for(int i = list.Count - 1; i >= index; i--)
                list.RemoveAt(i);
            aiChatControl1.LoadMessages(list);
        }

        void OnIsGeneratingChanged(bool isGenerating) {
            if(isGenerating) {
                overlayForm = new AIOverlayForm();
                overlayForm.ShowLoading(svgPalettePreview);
                aiChatControl1.Enabled = false; // lock chat input
            }
            else {
                overlayForm?.Close();
                overlayForm?.Dispose();
                overlayForm = null;
                aiChatControl1.Enabled = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            mvvmContext1.GetViewModel<GeneratePaletteUIViewModel>()?.CancelGeneration();
            base.OnFormClosing(e);
        }

        /// <summary>
        /// Initialize palette preview.
        /// </summary>
        void InitPreview() {
            svgPalettePreview.AllowElementSelection = false;
            svgPalettePreview.UsePaletteCache = Utils.DefaultBoolean.False; // Always reflect live palette changes.
            svgPalettePreview.SizeChanged += (sender, e) => svgPalettePreview.CalcZoomAndImageBounds();
        }

        void CurrentPaletteChanged(SvgPalette palette) {
            svgPalettePreview.SkinPalette = palette ?? CommonSkins.GetSkin(UserLookAndFeel.Default).SvgPalettes[Skin.DefaultSkinPaletteName];
            svgPalettePreview.Refresh();
        }

        async void aiChatControl1_MessageSending(object sender, DevExpress.AIIntegration.Blazor.Chat.WebView.AIChatControlMessageSendingEventArgs e) {
            var viewModel = mvvmContext1.GetViewModel<GeneratePaletteUIViewModel>();
            viewModel.InputPrompt = e.Text;

            await viewModel.Generate();

            var response = viewModel.Current?.Response;
            if(response?.IsValid == true)
                await aiChatControl1.AppendMessageAsync(response.Explanation, ChatRole.Assistant);
            else
                await aiChatControl1.AppendMessageAsync("Failed to generate a valid palette.", ChatRole.Assistant);
        }

        /// <summary>
        /// Clear chat UI and history when the user clicks Reset.
        /// </summary>
        void resetSimpleButton_Click(object sender, EventArgs e) {
            aiChatControl1.LoadMessages([]);
        }
    }
}
