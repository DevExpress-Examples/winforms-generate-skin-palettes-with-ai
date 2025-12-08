namespace DevExpress.AI.WinForms.AIGeneratePalette.UI {
    partial class GeneratePaletteDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePaletteDialog));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            closeSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            resetSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            lciApplySimpleButton = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciCloseSimpleButton = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            aiChatControl1 = new DevExpress.AIIntegration.WinForms.Chat.AIChatControl();
            svgPalettePreview = new DevExpress.XtraEditors.OtherDialogs.PaletteEditor.PalettePreview();
            mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(components);
            roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            roundedSkinPanel2 = new DevExpress.XtraEditors.RoundedSkinPanel();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciApplySimpleButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciCloseSimpleButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aiChatControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mvvmContext1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).BeginInit();
            roundedSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel2).BeginInit();
            roundedSkinPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.AutoSize = true;
            layoutControl1.Controls.Add(saveSimpleButton);
            layoutControl1.Controls.Add(closeSimpleButton);
            layoutControl1.Controls.Add(resetSimpleButton);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            layoutControl1.Location = new System.Drawing.Point(0, 814);
            layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(307, 481, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1398, 54);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // saveSimpleButton
            // 
            saveSimpleButton.AutoWidthInLayoutControl = true;
            saveSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            saveSimpleButton.Location = new System.Drawing.Point(1182, 12);
            saveSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            saveSimpleButton.MinimumSize = new System.Drawing.Size(100, 30);
            saveSimpleButton.Name = "saveSimpleButton";
            saveSimpleButton.Size = new System.Drawing.Size(100, 30);
            saveSimpleButton.StyleController = layoutControl1;
            saveSimpleButton.TabIndex = 2;
            saveSimpleButton.Text = "Save";
            // 
            // closeSimpleButton
            // 
            closeSimpleButton.AutoWidthInLayoutControl = true;
            closeSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            closeSimpleButton.Location = new System.Drawing.Point(1286, 12);
            closeSimpleButton.MinimumSize = new System.Drawing.Size(100, 30);
            closeSimpleButton.Name = "closeSimpleButton";
            closeSimpleButton.Size = new System.Drawing.Size(100, 30);
            closeSimpleButton.StyleController = layoutControl1;
            closeSimpleButton.TabIndex = 3;
            closeSimpleButton.Text = "Close";
            // 
            // resetSimpleButton
            // 
            resetSimpleButton.Location = new System.Drawing.Point(12, 12);
            resetSimpleButton.MinimumSize = new System.Drawing.Size(100, 30);
            resetSimpleButton.Name = "resetSimpleButton";
            resetSimpleButton.Size = new System.Drawing.Size(136, 30);
            resetSimpleButton.StyleController = layoutControl1;
            resetSimpleButton.TabIndex = 0;
            resetSimpleButton.Text = "Reset";
            resetSimpleButton.Click += resetSimpleButton_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new XtraLayout.BaseLayoutItem[] { lciApplySimpleButton, emptySpaceItem1, lciCloseSimpleButton, layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1398, 54);
            Root.TextVisible = false;
            // 
            // lciApplySimpleButton
            // 
            lciApplySimpleButton.Control = saveSimpleButton;
            lciApplySimpleButton.Location = new System.Drawing.Point(1170, 0);
            lciApplySimpleButton.Name = "lciApplySimpleButton";
            lciApplySimpleButton.Size = new System.Drawing.Size(104, 34);
            lciApplySimpleButton.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(140, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(1030, 34);
            // 
            // lciCloseSimpleButton
            // 
            lciCloseSimpleButton.Control = closeSimpleButton;
            lciCloseSimpleButton.Location = new System.Drawing.Point(1274, 0);
            lciCloseSimpleButton.Name = "lciCloseSimpleButton";
            lciCloseSimpleButton.Size = new System.Drawing.Size(104, 34);
            lciCloseSimpleButton.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = resetSimpleButton;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(140, 34);
            layoutControlItem1.TextVisible = false;
            // 
            // aiChatControl1
            // 
            aiChatControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            aiChatControl1.Appearance.Options.UseBackColor = true;
            aiChatControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            aiChatControl1.Location = new System.Drawing.Point(0, 0);
            aiChatControl1.Name = "aiChatControl1";
            aiChatControl1.Size = new System.Drawing.Size(449, 814);
            aiChatControl1.TabIndex = 8;
            aiChatControl1.MessageSent += aiChatControl1_MessageSent;
            // 
            // svgPalettePreview
            // 
            svgPalettePreview.AllowDragIcon = false;
            svgPalettePreview.AllowDrawTransparentBackground = false;
            svgPalettePreview.AllowFitSvgImage = false;
            svgPalettePreview.AllowMultiselectionByControlKey = false;
            svgPalettePreview.AllowZoomChange = false;
            svgPalettePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            svgPalettePreview.Location = new System.Drawing.Point(450, 0);
            svgPalettePreview.Name = "svgPalettePreview";
            svgPalettePreview.SelectionUpdate = true;
            svgPalettePreview.Size = new System.Drawing.Size(948, 814);
            svgPalettePreview.TabIndex = 3;
            svgPalettePreview.UsePaletteCache = Utils.DefaultBoolean.True;
            // 
            // mvvmContext1
            // 
            mvvmContext1.ContainerControl = this;
            mvvmContext1.ViewModelType = typeof(GeneratePaletteUIViewModel);
            // 
            // roundedSkinPanel1
            // 
            roundedSkinPanel1.Controls.Add(svgPalettePreview);
            roundedSkinPanel1.Controls.Add(roundedSkinPanel2);
            roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            roundedSkinPanel1.Location = new System.Drawing.Point(0, 0);
            roundedSkinPanel1.Name = "roundedSkinPanel1";
            roundedSkinPanel1.Size = new System.Drawing.Size(1398, 814);
            roundedSkinPanel1.TabIndex = 1;
            roundedSkinPanel1.Text = "roundedSkinPanel1";
            // 
            // roundedSkinPanel2
            // 
            roundedSkinPanel2.BorderStyle = XtraEditors.RoundedPanelBorderStyle.Rectangular;
            roundedSkinPanel2.Controls.Add(aiChatControl1);
            roundedSkinPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            roundedSkinPanel2.Location = new System.Drawing.Point(0, 0);
            roundedSkinPanel2.Name = "roundedSkinPanel2";
            roundedSkinPanel2.Size = new System.Drawing.Size(450, 814);
            roundedSkinPanel2.TabIndex = 0;
            // 
            // GeneratePaletteDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1398, 868);
            Controls.Add(roundedSkinPanel1);
            Controls.Add(layoutControl1);
            IconOptions.SvgImage = (Utils.Svg.SvgImage)resources.GetObject("GeneratePaletteDialog.IconOptions.SvgImage");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "GeneratePaletteDialog";
            Text = "Generate Palette";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciApplySimpleButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciCloseSimpleButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)aiChatControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mvvmContext1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).EndInit();
            roundedSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel2).EndInit();
            roundedSkinPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.OtherDialogs.PaletteEditor.PalettePreview svgPalettePreview;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem lciApplySimpleButton;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Utils.MVVM.MVVMContext mvvmContext1;
        private AIIntegration.WinForms.Chat.AIChatControl aiChatControl1;
        private XtraEditors.SimpleButton closeSimpleButton;
        private XtraLayout.LayoutControlItem lciCloseSimpleButton;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel2;
        private XtraEditors.SimpleButton resetSimpleButton;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}