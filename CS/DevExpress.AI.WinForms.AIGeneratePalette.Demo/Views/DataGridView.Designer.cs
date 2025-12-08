namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Views
{
    partial class DataGridView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            customerBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            printPreviewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageGrid = new DevExpress.XtraBars.Ribbon.RibbonPage();
            a = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).BeginInit();
            roundedSkinPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = customerBindingSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(738, 448);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // gridView1
            // 
            gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirstName, colLastName, colCountry, colCity, colAddress, colPhone, colPostalCode, colFullName });
            gridView1.DetailHeight = 239;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 533;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            colFirstName.FieldName = "FirstName";
            colFirstName.Name = "colFirstName";
            colFirstName.Visible = true;
            colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            colLastName.FieldName = "LastName";
            colLastName.Name = "colLastName";
            colLastName.Visible = true;
            colLastName.VisibleIndex = 2;
            // 
            // colCountry
            // 
            colCountry.FieldName = "Country";
            colCountry.Name = "colCountry";
            colCountry.Visible = true;
            colCountry.VisibleIndex = 3;
            // 
            // colCity
            // 
            colCity.FieldName = "City";
            colCity.Name = "colCity";
            colCity.Visible = true;
            colCity.VisibleIndex = 4;
            // 
            // colAddress
            // 
            colAddress.FieldName = "Address";
            colAddress.Name = "colAddress";
            colAddress.Visible = true;
            colAddress.VisibleIndex = 5;
            // 
            // colPhone
            // 
            colPhone.FieldName = "Phone";
            colPhone.Name = "colPhone";
            colPhone.Visible = true;
            colPhone.VisibleIndex = 6;
            // 
            // colPostalCode
            // 
            colPostalCode.FieldName = "PostalCode";
            colPostalCode.Name = "colPostalCode";
            colPostalCode.Visible = true;
            colPostalCode.VisibleIndex = 7;
            // 
            // colFullName
            // 
            colFullName.FieldName = "FullName";
            colFullName.Name = "colFullName";
            colFullName.OptionsColumn.ReadOnly = true;
            colFullName.Visible = true;
            colFullName.VisibleIndex = 8;
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new Padding(20, 21, 20, 21);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, printPreviewBarButtonItem, deleteBarButtonItem });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.Margin = new Padding(2);
            ribbonControl1.MaxItemId = 3;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 220;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPageGrid });
            ribbonControl1.ShowToolbarCustomizeItem = false;
            ribbonControl1.Size = new Size(738, 150);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // printPreviewBarButtonItem
            // 
            printPreviewBarButtonItem.Caption = "Print";
            printPreviewBarButtonItem.Id = 1;
            printPreviewBarButtonItem.ImageOptions.ImageUri.Uri = "Print";
            printPreviewBarButtonItem.Name = "printPreviewBarButtonItem";
            printPreviewBarButtonItem.ItemClick += barButtonItem1_ItemClick;
            // 
            // deleteBarButtonItem
            // 
            deleteBarButtonItem.Caption = "Delete";
            deleteBarButtonItem.Id = 2;
            deleteBarButtonItem.ImageOptions.ImageUri.Uri = "Delete";
            deleteBarButtonItem.Name = "deleteBarButtonItem";
            deleteBarButtonItem.ItemClick += barButtonItem2_ItemClick;
            // 
            // ribbonPageGrid
            // 
            ribbonPageGrid.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { a });
            ribbonPageGrid.Name = "ribbonPageGrid";
            ribbonPageGrid.Text = "Grid";
            // 
            // a
            // 
            a.ItemLinks.Add(printPreviewBarButtonItem);
            a.ItemLinks.Add(deleteBarButtonItem);
            a.Name = "a";
            a.Text = "Actions";
            // 
            // roundedSkinPanel1
            // 
            roundedSkinPanel1.Controls.Add(gridControl1);
            roundedSkinPanel1.Dock = DockStyle.Fill;
            roundedSkinPanel1.Location = new Point(0, 150);
            roundedSkinPanel1.Name = "roundedSkinPanel1";
            roundedSkinPanel1.Size = new Size(756, 363);
            roundedSkinPanel1.TabIndex = 5;
            roundedSkinPanel1.Text = "roundedSkinPanel1";
            // 
            // DataGridView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedSkinPanel1);
            Controls.Add(ribbonControl1);
            Name = "DataGridView";
            Size = new Size(738, 598);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).EndInit();
            roundedSkinPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGrid;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup a;
        private DevExpress.XtraBars.BarButtonItem printPreviewBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private DevExpress.XtraEditors.RoundedSkinPanel roundedSkinPanel1;
    }
}
