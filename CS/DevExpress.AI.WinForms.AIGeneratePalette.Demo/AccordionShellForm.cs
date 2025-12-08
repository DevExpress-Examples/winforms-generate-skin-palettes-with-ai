using System;
using System.Linq;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.AI;
using DevExpress.AI.WinForms.AIGeneratePalette.Persistence;
using DevExpress.AI.WinForms.AIGeneratePalette.UI;
using DevExpress.AIIntegration;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Svg.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo
{
    public partial class AccordionShellForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        AccordionShellForm() {
            InitializeComponent();
        }
        public AccordionShellForm(IServiceProvider serviceProvider) : this() {
            Services = serviceProvider;
            InitNavigationItems();
            InitAccentColors();
        }
        void OnNavigationFrameQueryControl(object sender, QueryControlEventArgs e) {
            e.Control = (Control)Services.GetService((Type)((NavigationPage)e.Page).Tag);
        }

        void InitNavigationItems() {
            employeeViewAccordionElement.Tag = employeeViewPage.Tag = typeof(Views.EmployeeView);
            dataGridViewPage.Tag = dataGridViewAccordionElement.Tag = typeof(Views.DataGridView);

            navigationAccordion.SelectElement(navigationAccordion.Elements[0].Elements[0]);
        }


        void OnSelectedAccordionElementChanged(object sender, SelectedElementChangedEventArgs e) {
            viewNavigationFrame.SelectedPage = (NavigationPage)viewNavigationFrame.Pages.First(p => p.Tag == e.Element.Tag);
        }
        public IServiceProvider Services { get; private set; }

        void InitAccentColors() {
            SkinHelper.InitTrackWindowsAppMode(bciTrackWindowsAppMode);
            bciTrackWindowsAppMode.SuperTip = new SuperToolTip();
            bciTrackWindowsAppMode.SuperTip.Items.Add("This setting is available for WXI, Basic, and Bezier skins.");
            bciTrackWindowsAppMode.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
            SkinHelper.InitResetToOriginalPalette(bciOriginalPalette);
            SkinHelper.InitTrackWindowsAccentColor(bciTrackWindowsAccentColor);
            SkinHelper.InitCustomAccentColor(Ribbon.Manager, bbiCustomColors);
            bbiCustomColors.SuperTip = new SuperToolTip();
            bbiCustomColors.SuperTip.Items.Add("Custom Accent Color.");
            bbiCustomColors.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
            SkinHelper.InitCustomAccentColor2(Ribbon.Manager, bbiCustomColors2);
            bbiCustomColors2.SuperTip = new SuperToolTip();
            bbiCustomColors2.SuperTip.Items.Add("Custom Accent Color 2.");
            bbiCustomColors2.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
        }
        /// <summary>
        /// Opens the AI Generation dialog (modal) allowing the user to iteratively craft a custom palette.
        /// </summary>
        void aiGeneratePaletteButton_ItemClick(object sender, ItemClickEventArgs e) {
            if(!UserLookAndFeel.Default.IsSvgSkin()) {
                XtraMessageBox.Show(this, "The current skin does not support SVG palettes. Please switch to an SVG skin and try again.", "SVG Skin Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                using(GeneratePaletteDialog dialog = new GeneratePaletteDialog()) {
                    dialog.StartPosition = FormStartPosition.CenterParent;
                    dialog.ShowDialog(this);
                }
            }
        }
        /// <summary>
        /// Clears all saved palettes (both in-memory repository and persisted JSON) and instructs user to restart.
        /// </summary>
        void resetAISavedPalette_ItemClick(object sender, ItemClickEventArgs e) {
            AIPaletteRepository.Default.Palettes.Clear();
            string saveToJson = AIPaletteRepository.SaveToJson();
            Properties.Settings.Default.CustomPalettes_JSON = saveToJson;
            Properties.Settings.Default.Save();
            XtraMessageBox.Show(this, "All saved AI palettes have been removed. Restart application.", "Palettes Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Persist AI-generated palette repository when application window closes.
        /// </summary>
        void AccordionShellForm_FormClosed(object sender, FormClosedEventArgs e) {
            string saveToJson = AIPaletteRepository.SaveToJson();

            Properties.Settings.Default.CustomPalettes_JSON = saveToJson;
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Change AI model.
        /// </summary>
        void gptCheckItem_CheckedChanged(object sender, ItemClickEventArgs e) {
            IChatClient chatClient = ChatClientFactory.Create((string)e.Item.Tag);
            var defaultContainer = AIExtensionsContainerDesktop.Default;
            defaultContainer.UnregisterChatClient();
            defaultContainer.RegisterChatClient(chatClient);
        }
    }
}
