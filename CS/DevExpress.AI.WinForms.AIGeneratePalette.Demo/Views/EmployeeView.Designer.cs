using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Views {
    partial class EmployeeView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new XtraBars.Ribbon.GalleryItemGroup();
            XtraBars.Ribbon.GalleryItem galleryItem1 = new XtraBars.Ribbon.GalleryItem();
            XtraBars.Ribbon.GalleryItem galleryItem2 = new XtraBars.Ribbon.GalleryItem();
            XtraBars.Ribbon.GalleryItem galleryItem3 = new XtraBars.Ribbon.GalleryItem();
            XtraBars.Ribbon.GalleryItem galleryItem4 = new XtraBars.Ribbon.GalleryItem();
            XtraBars.Ribbon.GalleryItem galleryItem5 = new XtraBars.Ribbon.GalleryItem();
            Skins.SkinPaddingEdges skinPaddingEdges1 = new Skins.SkinPaddingEdges();
            Skins.SkinPaddingEdges skinPaddingEdges2 = new Skins.SkinPaddingEdges();
            Utils.Drawing.StubGlyphOptions stubGlyphOptions1 = new Utils.Drawing.StubGlyphOptions();
            XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new XtraEditors.Controls.EditorButtonImageOptions();
            Utils.SerializableAppearanceObject serializableAppearanceObject1 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject2 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject3 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject4 = new Utils.SerializableAppearanceObject();
            XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new XtraEditors.Controls.EditorButtonImageOptions();
            Utils.SerializableAppearanceObject serializableAppearanceObject5 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject6 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject7 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject8 = new Utils.SerializableAppearanceObject();
            XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new XtraEditors.Controls.EditorButtonImageOptions();
            Utils.SerializableAppearanceObject serializableAppearanceObject9 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject10 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject11 = new Utils.SerializableAppearanceObject();
            Utils.SerializableAppearanceObject serializableAppearanceObject12 = new Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            FirstNameTextEdit = new TextEdit();
            bindingSource = new BindingSource(components);
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            LastNameTextEdit = new TextEdit();
            PrefixImageComboBoxEdit = new ImageComboBoxEdit();
            DepartmentImageComboBoxEdit = new ImageComboBoxEdit();
            StatusImageComboBoxEdit = new ImageComboBoxEdit();
            gridControlEvaluations = new DevExpress.XtraGrid.GridControl();
            evaluationsBindingSource = new BindingSource(components);
            gvEvaluations = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            HomePhoneTextEdit = new ButtonEdit();
            MobilePhoneTextEdit = new ButtonEdit();
            EmailTextEdit = new ButtonEdit();
            PhotoPictureEdit = new PictureEdit();
            AddressTextEdit = new TextEdit();
            CityTextEdit = new TextEdit();
            StateImageComboBoxEdit = new ImageComboBoxEdit();
            ZipCodeTextEdit = new TextEdit();
            FullNameTextEdit = new TextEdit();
            HireDateDateEdit = new DateEdit();
            BirthDateDateEdit = new DateEdit();
            TitleTextEdit = new TextEdit();
            gridControlTasks = new DevExpress.XtraGrid.GridControl();
            assignedTasksBindingSource = new BindingSource(components);
            gvTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSubject1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colCompletion = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemProgressBar1 = new RepositoryItemProgressBar();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            autoGeneratedGroup0 = new DevExpress.XtraLayout.LayoutControlGroup();
            ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForPrefix = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForEvaluations = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForHomePhone = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForMobilePhone = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForPhoto = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForHireDate = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForBirthDate = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ItemForTitle = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForZipCode = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForTasks = new DevExpress.XtraLayout.LayoutControlItem();
            behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(components);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrefixImageComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentImageComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusImageComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlEvaluations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)evaluationsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvEvaluations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomePhoneTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MobilePhoneTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CityTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StateImageComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZipCodeTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FullNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HireDateDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HireDateDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitleTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assignedTasksBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)autoGeneratedGroup0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPrefix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEvaluations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForHomePhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForMobilePhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFullName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForHireDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForBirthDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForZipCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).BeginInit();
            SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.AllowCustomization = false;
            dataLayoutControl1.AllowGeneratingCollectionProperties = Utils.DefaultBoolean.True;
            dataLayoutControl1.AllowGeneratingNestedGroups = Utils.DefaultBoolean.True;
            dataLayoutControl1.Controls.Add(FirstNameTextEdit);
            dataLayoutControl1.Controls.Add(LastNameTextEdit);
            dataLayoutControl1.Controls.Add(PrefixImageComboBoxEdit);
            dataLayoutControl1.Controls.Add(DepartmentImageComboBoxEdit);
            dataLayoutControl1.Controls.Add(StatusImageComboBoxEdit);
            dataLayoutControl1.Controls.Add(gridControlEvaluations);
            dataLayoutControl1.Controls.Add(HomePhoneTextEdit);
            dataLayoutControl1.Controls.Add(MobilePhoneTextEdit);
            dataLayoutControl1.Controls.Add(EmailTextEdit);
            dataLayoutControl1.Controls.Add(PhotoPictureEdit);
            dataLayoutControl1.Controls.Add(AddressTextEdit);
            dataLayoutControl1.Controls.Add(CityTextEdit);
            dataLayoutControl1.Controls.Add(StateImageComboBoxEdit);
            dataLayoutControl1.Controls.Add(ZipCodeTextEdit);
            dataLayoutControl1.Controls.Add(FullNameTextEdit);
            dataLayoutControl1.Controls.Add(HireDateDateEdit);
            dataLayoutControl1.Controls.Add(BirthDateDateEdit);
            dataLayoutControl1.Controls.Add(TitleTextEdit);
            dataLayoutControl1.Controls.Add(gridControlTasks);
            dataLayoutControl1.DataSource = bindingSource;
            dataLayoutControl1.Dock = DockStyle.Fill;
            dataLayoutControl1.Location = new Point(0, 0);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(421, 117, 1099, 808);
            dataLayoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            dataLayoutControl1.Root = layoutControlGroup1;
            dataLayoutControl1.Size = new Size(1015, 576);
            dataLayoutControl1.TabIndex = 0;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // FirstNameTextEdit
            // 
            FirstNameTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "FirstName", true));
            FirstNameTextEdit.EnterMoveNextControl = true;
            FirstNameTextEdit.Location = new Point(87, 12);
            FirstNameTextEdit.MenuManager = ribbonControl1;
            FirstNameTextEdit.Name = "FirstNameTextEdit";
            FirstNameTextEdit.Properties.ValidateOnEnterKey = true;
            FirstNameTextEdit.Size = new Size(280, 20);
            FirstNameTextEdit.StyleController = dataLayoutControl1;
            FirstNameTextEdit.TabIndex = 8;
            // 
            // bindingSource
            // 
            bindingSource.DataSource = typeof(Model.Employee);
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barSubItem1, barButtonItem7, barButtonItem8, barButtonItem11, barButtonItem9, barButtonItem10, ribbonGalleryBarItem1, barButtonItem12, barButtonItem13 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 18;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1209, 0);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Save";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem1.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg";
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Close";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem2.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
            barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Save && Close";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg";
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Delete";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem4.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Mail Merge";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem5.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg";
            barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Meeting";
            barButtonItem6.Id = 6;
            barButtonItem6.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem6.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg";
            barButtonItem6.Name = "barButtonItem6";
            // 
            // barSubItem1
            // 
            barSubItem1.Caption = "Print";
            barSubItem1.Id = 8;
            barSubItem1.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barSubItem1.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg";
            barSubItem1.LinksPersistInfo.AddRange(new XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem7), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem8), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem9), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem10) });
            barSubItem1.Name = "barSubItem1";
            barSubItem1.ShowNavigationHeader = Utils.DefaultBoolean.True;
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "Employee Profile";
            barButtonItem7.Id = 9;
            barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "Summary Report";
            barButtonItem8.Id = 10;
            barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "Directory";
            barButtonItem9.Id = 12;
            barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "Task List";
            barButtonItem10.Id = 13;
            barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            barButtonItem11.Caption = "Task";
            barButtonItem11.Id = 11;
            barButtonItem11.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Task.svg";
            barButtonItem11.Name = "barButtonItem11";
            // 
            // ribbonGalleryBarItem1
            // 
            ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            // 
            // 
            // 
            ribbonGalleryBarItem1.Gallery.ColumnCount = 2;
            ribbonGalleryBarItem1.Gallery.DrawImageBackground = false;
            galleryItemGroup1.Caption = "Group1";
            galleryItem1.Caption = "Thank You Note";
            galleryItem2.Caption = "Employee Award";
            galleryItem3.Caption = "Service Excellence";
            galleryItem4.Caption = "Probation Notice";
            galleryItem5.Caption = "Welcome To DevAV";
            galleryItemGroup1.Items.AddRange(new XtraBars.Ribbon.GalleryItem[] { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5 });
            ribbonGalleryBarItem1.Gallery.Groups.AddRange(new XtraBars.Ribbon.GalleryItemGroup[] { galleryItemGroup1 });
            ribbonGalleryBarItem1.Gallery.ItemImageLocation = Utils.Locations.Left;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            ribbonGalleryBarItem1.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -1;
            skinPaddingEdges2.Top = -1;
            ribbonGalleryBarItem1.Gallery.ItemTextPadding = skinPaddingEdges2;
            ribbonGalleryBarItem1.Gallery.ShowItemText = true;
            ribbonGalleryBarItem1.Id = 14;
            ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItem12
            // 
            barButtonItem12.Caption = "Map It";
            barButtonItem12.Id = 15;
            barButtonItem12.ImageOptions.AllowGlyphSkinning = Utils.DefaultBoolean.False;
            barButtonItem12.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg";
            barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            barButtonItem13.Caption = "Reset Changes";
            barButtonItem13.Id = 17;
            barButtonItem13.Name = "barButtonItem13";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5, ribbonPageGroup6, ribbonPageGroup7 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "CONTACT";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.MergeOrder = 0;
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Save";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.AllowTextClipping = false;
            ribbonPageGroup2.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup2.ItemLinks.Add(barButtonItem13);
            ribbonPageGroup2.MergeOrder = 0;
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Edit";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.AllowTextClipping = false;
            ribbonPageGroup3.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup3.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup3.MergeOrder = 0;
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Delete";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup4.ItemLinks.Add(barSubItem1);
            ribbonPageGroup4.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup4.ItemLinks.Add(barButtonItem11);
            ribbonPageGroup4.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup4.MergeOrder = 0;
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Actions";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup5.ItemLinks.Add(ribbonGalleryBarItem1);
            ribbonPageGroup5.MergeOrder = 0;
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "Quick Letters";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.AllowTextClipping = false;
            ribbonPageGroup6.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup6.ItemLinks.Add(barButtonItem12);
            ribbonPageGroup6.MergeOrder = 0;
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            ribbonPageGroup6.Text = "View";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.AllowTextClipping = false;
            ribbonPageGroup7.CaptionButtonVisible = Utils.DefaultBoolean.False;
            ribbonPageGroup7.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup7.MergeOrder = 0;
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            ribbonPageGroup7.Text = "Close";
            // 
            // LastNameTextEdit
            // 
            LastNameTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "LastName", true));
            LastNameTextEdit.EnterMoveNextControl = true;
            LastNameTextEdit.Location = new Point(87, 36);
            LastNameTextEdit.MenuManager = ribbonControl1;
            LastNameTextEdit.Name = "LastNameTextEdit";
            LastNameTextEdit.Properties.ValidateOnEnterKey = true;
            LastNameTextEdit.Size = new Size(280, 20);
            LastNameTextEdit.StyleController = dataLayoutControl1;
            LastNameTextEdit.TabIndex = 9;
            // 
            // PrefixImageComboBoxEdit
            // 
            PrefixImageComboBoxEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Prefix", true));
            PrefixImageComboBoxEdit.EnterMoveNextControl = true;
            PrefixImageComboBoxEdit.Location = new Point(288, 108);
            PrefixImageComboBoxEdit.MenuManager = ribbonControl1;
            PrefixImageComboBoxEdit.Name = "PrefixImageComboBoxEdit";
            PrefixImageComboBoxEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            PrefixImageComboBoxEdit.Size = new Size(79, 20);
            PrefixImageComboBoxEdit.StyleController = dataLayoutControl1;
            PrefixImageComboBoxEdit.TabIndex = 11;
            // 
            // DepartmentImageComboBoxEdit
            // 
            DepartmentImageComboBoxEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Department", true));
            DepartmentImageComboBoxEdit.EnterMoveNextControl = true;
            DepartmentImageComboBoxEdit.Location = new Point(607, 12);
            DepartmentImageComboBoxEdit.MenuManager = ribbonControl1;
            DepartmentImageComboBoxEdit.Name = "DepartmentImageComboBoxEdit";
            DepartmentImageComboBoxEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            DepartmentImageComboBoxEdit.Size = new Size(396, 20);
            DepartmentImageComboBoxEdit.StyleController = dataLayoutControl1;
            DepartmentImageComboBoxEdit.TabIndex = 4;
            // 
            // StatusImageComboBoxEdit
            // 
            behaviorManager1.SetBehaviors(StatusImageComboBoxEdit, new Utils.Behaviors.Behavior[] { Utils.Behaviors.Common.StubGlyphBehavior.Create(typeof(XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), stubGlyphOptions1, new Size(16, 16)) });
            StatusImageComboBoxEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Status", true));
            StatusImageComboBoxEdit.EnterMoveNextControl = true;
            StatusImageComboBoxEdit.Location = new Point(607, 36);
            StatusImageComboBoxEdit.MenuManager = ribbonControl1;
            StatusImageComboBoxEdit.Name = "StatusImageComboBoxEdit";
            StatusImageComboBoxEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            StatusImageComboBoxEdit.Size = new Size(396, 20);
            StatusImageComboBoxEdit.StyleController = dataLayoutControl1;
            StatusImageComboBoxEdit.TabIndex = 6;
            // 
            // gridControlEvaluations
            // 
            gridControlEvaluations.DataSource = evaluationsBindingSource;
            gridControlEvaluations.Location = new Point(532, 122);
            gridControlEvaluations.MainView = gvEvaluations;
            gridControlEvaluations.Name = "gridControlEvaluations";
            gridControlEvaluations.Size = new Size(471, 166);
            gridControlEvaluations.TabIndex = 6;
            gridControlEvaluations.ViewCollection.AddRange(new XtraGrid.Views.Base.BaseView[] { gvEvaluations });
            // 
            // evaluationsBindingSource
            // 
            evaluationsBindingSource.DataMember = "Evaluations";
            evaluationsBindingSource.DataSource = bindingSource;
            // 
            // gvEvaluations
            // 
            gvEvaluations.Columns.AddRange(new XtraGrid.Columns.GridColumn[] { colCreatedOn, colSubject, colCreatedBy });
            gvEvaluations.GridControl = gridControlEvaluations;
            gvEvaluations.Name = "gvEvaluations";
            gvEvaluations.OptionsBehavior.FocusLeaveOnTab = true;
            gvEvaluations.OptionsSelection.EnableAppearanceHideSelection = false;
            gvEvaluations.OptionsView.AutoCalcPreviewLineCount = true;
            gvEvaluations.OptionsView.EnableAppearanceEvenRow = true;
            gvEvaluations.OptionsView.ShowGroupPanel = false;
            gvEvaluations.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False;
            gvEvaluations.OptionsView.ShowIndicator = false;
            gvEvaluations.OptionsView.ShowPreview = true;
            gvEvaluations.OptionsView.ShowVerticalLines = Utils.DefaultBoolean.False;
            gvEvaluations.PreviewFieldName = "Details";
            gvEvaluations.PreviewIndent = 0;
            // 
            // colCreatedOn
            // 
            colCreatedOn.AppearanceCell.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            colCreatedOn.AppearanceCell.Options.UseFont = true;
            colCreatedOn.Caption = "CREATED ON";
            colCreatedOn.FieldName = "CreatedOn";
            colCreatedOn.Name = "colCreatedOn";
            colCreatedOn.OptionsColumn.AllowEdit = false;
            colCreatedOn.OptionsColumn.AllowFocus = false;
            colCreatedOn.Visible = true;
            colCreatedOn.VisibleIndex = 0;
            colCreatedOn.Width = 82;
            // 
            // colSubject
            // 
            colSubject.Caption = "SUBJECT";
            colSubject.FieldName = "Subject";
            colSubject.Name = "colSubject";
            colSubject.OptionsColumn.AllowEdit = false;
            colSubject.OptionsColumn.AllowFocus = false;
            colSubject.Visible = true;
            colSubject.VisibleIndex = 1;
            colSubject.Width = 249;
            // 
            // colCreatedBy
            // 
            colCreatedBy.Caption = "MANAGER";
            colCreatedBy.FieldName = "Manager";
            colCreatedBy.Name = "colCreatedBy";
            colCreatedBy.OptionsColumn.AllowEdit = false;
            colCreatedBy.OptionsColumn.AllowFocus = false;
            colCreatedBy.Visible = true;
            colCreatedBy.VisibleIndex = 2;
            colCreatedBy.Width = 136;
            // 
            // HomePhoneTextEdit
            // 
            HomePhoneTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "HomePhone", true));
            HomePhoneTextEdit.EnterMoveNextControl = true;
            HomePhoneTextEdit.Location = new Point(87, 220);
            HomePhoneTextEdit.MenuManager = ribbonControl1;
            HomePhoneTextEdit.Name = "HomePhoneTextEdit";
            editorButtonImageOptions1.SvgImageSize = new Size(16, 16);
            HomePhoneTextEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, Utils.ToolTipAnchor.Default) });
            HomePhoneTextEdit.Properties.ValidateOnEnterKey = true;
            HomePhoneTextEdit.Size = new Size(421, 20);
            HomePhoneTextEdit.StyleController = dataLayoutControl1;
            HomePhoneTextEdit.TabIndex = 12;
            // 
            // MobilePhoneTextEdit
            // 
            MobilePhoneTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "MobilePhone", true));
            MobilePhoneTextEdit.EnterMoveNextControl = true;
            MobilePhoneTextEdit.Location = new Point(87, 244);
            MobilePhoneTextEdit.MenuManager = ribbonControl1;
            MobilePhoneTextEdit.Name = "MobilePhoneTextEdit";
            editorButtonImageOptions2.SvgImageSize = new Size(16, 16);
            MobilePhoneTextEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, Utils.ToolTipAnchor.Default) });
            MobilePhoneTextEdit.Properties.ValidateOnEnterKey = true;
            MobilePhoneTextEdit.Size = new Size(421, 20);
            MobilePhoneTextEdit.StyleController = dataLayoutControl1;
            MobilePhoneTextEdit.TabIndex = 13;
            // 
            // EmailTextEdit
            // 
            EmailTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Email", true));
            EmailTextEdit.EnterMoveNextControl = true;
            EmailTextEdit.Location = new Point(87, 268);
            EmailTextEdit.MenuManager = ribbonControl1;
            EmailTextEdit.Name = "EmailTextEdit";
            editorButtonImageOptions3.SvgImageSize = new Size(16, 16);
            EmailTextEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, Utils.ToolTipAnchor.Default) });
            EmailTextEdit.Properties.ValidateOnEnterKey = true;
            EmailTextEdit.Size = new Size(421, 20);
            EmailTextEdit.StyleController = dataLayoutControl1;
            EmailTextEdit.TabIndex = 14;
            // 
            // PhotoPictureEdit
            // 
            PhotoPictureEdit.EditValue = resources.GetObject("PhotoPictureEdit.EditValue");
            PhotoPictureEdit.Location = new Point(389, 12);
            PhotoPictureEdit.MenuManager = ribbonControl1;
            PhotoPictureEdit.Name = "PhotoPictureEdit";
            PhotoPictureEdit.Properties.PictureStoreMode = XtraEditors.Controls.PictureStoreMode.ByteArray;
            PhotoPictureEdit.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom;
            PhotoPictureEdit.Size = new Size(119, 116);
            PhotoPictureEdit.StyleController = dataLayoutControl1;
            PhotoPictureEdit.TabIndex = 17;
            // 
            // AddressTextEdit
            // 
            AddressTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.Line", true));
            AddressTextEdit.EnterMoveNextControl = true;
            AddressTextEdit.Location = new Point(87, 152);
            AddressTextEdit.MenuManager = ribbonControl1;
            AddressTextEdit.Name = "AddressTextEdit";
            AddressTextEdit.Size = new Size(421, 20);
            AddressTextEdit.StyleController = dataLayoutControl1;
            AddressTextEdit.TabIndex = 19;
            // 
            // CityTextEdit
            // 
            CityTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.City", true));
            CityTextEdit.EnterMoveNextControl = true;
            CityTextEdit.Location = new Point(87, 176);
            CityTextEdit.MenuManager = ribbonControl1;
            CityTextEdit.Name = "CityTextEdit";
            CityTextEdit.Size = new Size(164, 20);
            CityTextEdit.StyleController = dataLayoutControl1;
            CityTextEdit.TabIndex = 20;
            // 
            // StateImageComboBoxEdit
            // 
            StateImageComboBoxEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.State", true));
            StateImageComboBoxEdit.EnterMoveNextControl = true;
            StateImageComboBoxEdit.Location = new Point(286, 176);
            StateImageComboBoxEdit.MenuManager = ribbonControl1;
            StateImageComboBoxEdit.Name = "StateImageComboBoxEdit";
            StateImageComboBoxEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            StateImageComboBoxEdit.Properties.DropDownRows = 14;
            StateImageComboBoxEdit.Properties.Sorted = true;
            StateImageComboBoxEdit.Size = new Size(81, 20);
            StateImageComboBoxEdit.StyleController = dataLayoutControl1;
            StateImageComboBoxEdit.TabIndex = 21;
            // 
            // ZipCodeTextEdit
            // 
            ZipCodeTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Address.ZipCode", true));
            ZipCodeTextEdit.EnterMoveNextControl = true;
            ZipCodeTextEdit.Location = new Point(418, 176);
            ZipCodeTextEdit.MenuManager = ribbonControl1;
            ZipCodeTextEdit.Name = "ZipCodeTextEdit";
            ZipCodeTextEdit.Size = new Size(90, 20);
            ZipCodeTextEdit.StyleController = dataLayoutControl1;
            ZipCodeTextEdit.TabIndex = 22;
            // 
            // FullNameTextEdit
            // 
            FullNameTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "FullNameBindable", true));
            FullNameTextEdit.Location = new Point(87, 60);
            FullNameTextEdit.MenuManager = ribbonControl1;
            FullNameTextEdit.Name = "FullNameTextEdit";
            FullNameTextEdit.Size = new Size(280, 20);
            FullNameTextEdit.StyleController = dataLayoutControl1;
            FullNameTextEdit.TabIndex = 23;
            // 
            // HireDateDateEdit
            // 
            HireDateDateEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "HireDate", true));
            HireDateDateEdit.EditValue = null;
            HireDateDateEdit.EnterMoveNextControl = true;
            HireDateDateEdit.Location = new Point(607, 60);
            HireDateDateEdit.MenuManager = ribbonControl1;
            HireDateDateEdit.Name = "HireDateDateEdit";
            HireDateDateEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            HireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            HireDateDateEdit.Size = new Size(396, 20);
            HireDateDateEdit.StyleController = dataLayoutControl1;
            HireDateDateEdit.TabIndex = 7;
            // 
            // BirthDateDateEdit
            // 
            BirthDateDateEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "BirthDate", true));
            BirthDateDateEdit.EditValue = null;
            BirthDateDateEdit.EnterMoveNextControl = true;
            BirthDateDateEdit.Location = new Point(87, 84);
            BirthDateDateEdit.MenuManager = ribbonControl1;
            BirthDateDateEdit.Name = "BirthDateDateEdit";
            BirthDateDateEdit.Properties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthDateDateEdit.Size = new Size(280, 20);
            BirthDateDateEdit.StyleController = dataLayoutControl1;
            BirthDateDateEdit.TabIndex = 16;
            // 
            // TitleTextEdit
            // 
            TitleTextEdit.DataBindings.Add(new Binding("EditValue", bindingSource, "Title", true));
            TitleTextEdit.EnterMoveNextControl = true;
            TitleTextEdit.Location = new Point(87, 108);
            TitleTextEdit.MenuManager = ribbonControl1;
            TitleTextEdit.Name = "TitleTextEdit";
            TitleTextEdit.Properties.ValidateOnEnterKey = true;
            TitleTextEdit.Size = new Size(164, 20);
            TitleTextEdit.StyleController = dataLayoutControl1;
            TitleTextEdit.TabIndex = 5;
            // 
            // gridControlTasks
            // 
            gridControlTasks.DataSource = assignedTasksBindingSource;
            gridControlTasks.Location = new Point(12, 328);
            gridControlTasks.MainView = gvTasks;
            gridControlTasks.Name = "gridControlTasks";
            gridControlTasks.RepositoryItems.AddRange(new RepositoryItem[] { repositoryItemProgressBar1 });
            gridControlTasks.Size = new Size(991, 236);
            gridControlTasks.TabIndex = 18;
            gridControlTasks.ViewCollection.AddRange(new XtraGrid.Views.Base.BaseView[] { gvTasks });
            // 
            // assignedTasksBindingSource
            // 
            assignedTasksBindingSource.DataMember = "AssignedTasks";
            assignedTasksBindingSource.DataSource = bindingSource;
            // 
            // gvTasks
            // 
            gvTasks.Appearance.HideSelectionRow.BackColor = Color.Transparent;
            gvTasks.Appearance.HideSelectionRow.Options.UseBackColor = true;
            gvTasks.Columns.AddRange(new XtraGrid.Columns.GridColumn[] { colPriority, colDueDate, colSubject1, colDescription, colCompletion });
            gvTasks.GridControl = gridControlTasks;
            gvTasks.Name = "gvTasks";
            gvTasks.OptionsBehavior.FocusLeaveOnTab = true;
            gvTasks.OptionsSelection.EnableAppearanceHideSelection = false;
            gvTasks.OptionsView.AutoCalcPreviewLineCount = true;
            gvTasks.OptionsView.EnableAppearanceEvenRow = true;
            gvTasks.OptionsView.ShowGroupPanel = false;
            gvTasks.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False;
            gvTasks.OptionsView.ShowIndicator = false;
            gvTasks.OptionsView.ShowPreview = true;
            gvTasks.OptionsView.ShowVerticalLines = Utils.DefaultBoolean.False;
            gvTasks.PreviewFieldName = "Description";
            gvTasks.PreviewIndent = 0;
            gvTasks.PreviewLineCount = 3;
            // 
            // colPriority
            // 
            colPriority.Caption = "PRIORITY";
            colPriority.FieldName = "Priority";
            colPriority.Name = "colPriority";
            colPriority.OptionsColumn.AllowEdit = false;
            colPriority.OptionsColumn.AllowFocus = false;
            colPriority.Visible = true;
            colPriority.VisibleIndex = 0;
            colPriority.Width = 133;
            // 
            // colDueDate
            // 
            colDueDate.AppearanceCell.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            colDueDate.AppearanceCell.Options.UseFont = true;
            colDueDate.Caption = "DUE DATE";
            colDueDate.FieldName = "DueDate";
            colDueDate.Name = "colDueDate";
            colDueDate.OptionsColumn.AllowEdit = false;
            colDueDate.OptionsColumn.AllowFocus = false;
            colDueDate.Visible = true;
            colDueDate.VisibleIndex = 1;
            colDueDate.Width = 133;
            // 
            // colSubject1
            // 
            colSubject1.Caption = "SUBJECT";
            colSubject1.FieldName = "Subject";
            colSubject1.Name = "colSubject1";
            colSubject1.OptionsColumn.AllowEdit = false;
            colSubject1.OptionsColumn.AllowFocus = false;
            colSubject1.Visible = true;
            colSubject1.VisibleIndex = 2;
            colSubject1.Width = 316;
            // 
            // colDescription
            // 
            colDescription.Caption = "DESCRIPTION";
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.OptionsColumn.AllowEdit = false;
            colDescription.OptionsColumn.AllowFocus = false;
            colDescription.Width = 439;
            // 
            // colCompletion
            // 
            colCompletion.Caption = "COMPLETION";
            colCompletion.ColumnEdit = repositoryItemProgressBar1;
            colCompletion.FieldName = "Completion";
            colCompletion.Name = "colCompletion";
            colCompletion.OptionsColumn.AllowEdit = false;
            colCompletion.OptionsColumn.AllowFocus = false;
            colCompletion.Visible = true;
            colCompletion.VisibleIndex = 3;
            colCompletion.Width = 402;
            // 
            // repositoryItemProgressBar1
            // 
            repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            repositoryItemProgressBar1.ShowTitle = true;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new XtraLayout.BaseLayoutItem[] { autoGeneratedGroup0, ItemForTasks });
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new Size(1015, 576);
            layoutControlGroup1.TextVisible = false;
            // 
            // autoGeneratedGroup0
            // 
            autoGeneratedGroup0.AllowDrawBackground = false;
            autoGeneratedGroup0.CustomizationFormText = "autoGeneratedGroup0";
            autoGeneratedGroup0.GroupBordersVisible = false;
            autoGeneratedGroup0.Items.AddRange(new XtraLayout.BaseLayoutItem[] { ItemForFirstName, ItemForLastName, ItemForPrefix, ItemForDepartment, ItemForStatus, ItemForEvaluations, ItemForHomePhone, ItemForMobilePhone, ItemForEmail, ItemForPhoto, emptySpaceItem1, ItemForAddress, ItemForCity, emptySpaceItem2, ItemForFullName, ItemForHireDate, ItemForBirthDate, emptySpaceItem3, emptySpaceItem4, emptySpaceItem5, ItemForTitle, ItemForState, ItemForZipCode });
            autoGeneratedGroup0.Location = new Point(0, 0);
            autoGeneratedGroup0.Name = "autoGeneratedGroup0";
            autoGeneratedGroup0.Size = new Size(995, 300);
            // 
            // ItemForFirstName
            // 
            ItemForFirstName.Control = FirstNameTextEdit;
            ItemForFirstName.CustomizationFormText = "First Name";
            ItemForFirstName.Location = new Point(0, 0);
            ItemForFirstName.Name = "ItemForFirstName";
            ItemForFirstName.Size = new Size(359, 24);
            ItemForFirstName.Text = "First Name";
            ItemForFirstName.TextSize = new Size(63, 13);
            // 
            // ItemForLastName
            // 
            ItemForLastName.Control = LastNameTextEdit;
            ItemForLastName.CustomizationFormText = "Last Name";
            ItemForLastName.Location = new Point(0, 24);
            ItemForLastName.Name = "ItemForLastName";
            ItemForLastName.Size = new Size(359, 24);
            ItemForLastName.Text = "Last Name";
            ItemForLastName.TextSize = new Size(63, 13);
            // 
            // ItemForPrefix
            // 
            ItemForPrefix.Control = PrefixImageComboBoxEdit;
            ItemForPrefix.CustomizationFormText = "Prefix";
            ItemForPrefix.Location = new Point(243, 96);
            ItemForPrefix.Name = "ItemForPrefix";
            ItemForPrefix.Size = new Size(116, 24);
            ItemForPrefix.Text = "Prefix";
            ItemForPrefix.TextAlignMode = XtraLayout.TextAlignModeItem.AutoSize;
            ItemForPrefix.TextSize = new Size(28, 13);
            ItemForPrefix.TextToControlDistance = 5;
            // 
            // ItemForDepartment
            // 
            ItemForDepartment.Control = DepartmentImageComboBoxEdit;
            ItemForDepartment.CustomizationFormText = "Department";
            ItemForDepartment.Location = new Point(520, 0);
            ItemForDepartment.Name = "ItemForDepartment";
            ItemForDepartment.Size = new Size(475, 24);
            ItemForDepartment.Text = "Department";
            ItemForDepartment.TextSize = new Size(63, 13);
            // 
            // ItemForStatus
            // 
            ItemForStatus.Control = StatusImageComboBoxEdit;
            ItemForStatus.CustomizationFormText = "Status";
            ItemForStatus.Location = new Point(520, 24);
            ItemForStatus.Name = "ItemForStatus";
            ItemForStatus.Size = new Size(475, 24);
            ItemForStatus.Text = "Status";
            ItemForStatus.TextSize = new Size(63, 13);
            // 
            // ItemForEvaluations
            // 
            ItemForEvaluations.Control = gridControlEvaluations;
            ItemForEvaluations.CustomizationFormText = "Evaluations";
            ItemForEvaluations.Location = new Point(520, 92);
            ItemForEvaluations.Name = "ItemForEvaluations";
            ItemForEvaluations.Size = new Size(475, 188);
            ItemForEvaluations.Text = "Evaluations";
            ItemForEvaluations.TextAlignMode = XtraLayout.TextAlignModeItem.AutoSize;
            ItemForEvaluations.TextLocation = Utils.Locations.Top;
            ItemForEvaluations.TextSize = new Size(55, 13);
            ItemForEvaluations.TextToControlDistance = 5;
            // 
            // ItemForHomePhone
            // 
            ItemForHomePhone.Control = HomePhoneTextEdit;
            ItemForHomePhone.CustomizationFormText = "Home Phone";
            ItemForHomePhone.Location = new Point(0, 208);
            ItemForHomePhone.Name = "ItemForHomePhone";
            ItemForHomePhone.Size = new Size(500, 24);
            ItemForHomePhone.Text = "Home Phone";
            ItemForHomePhone.TextSize = new Size(63, 13);
            // 
            // ItemForMobilePhone
            // 
            ItemForMobilePhone.Control = MobilePhoneTextEdit;
            ItemForMobilePhone.CustomizationFormText = "Mobile Phone";
            ItemForMobilePhone.Location = new Point(0, 232);
            ItemForMobilePhone.Name = "ItemForMobilePhone";
            ItemForMobilePhone.Size = new Size(500, 24);
            ItemForMobilePhone.Text = "Mobile Phone";
            ItemForMobilePhone.TextSize = new Size(63, 13);
            // 
            // ItemForEmail
            // 
            ItemForEmail.Control = EmailTextEdit;
            ItemForEmail.CustomizationFormText = "Email";
            ItemForEmail.Location = new Point(0, 256);
            ItemForEmail.Name = "ItemForEmail";
            ItemForEmail.Size = new Size(500, 24);
            ItemForEmail.Text = "Email";
            ItemForEmail.TextSize = new Size(63, 13);
            // 
            // ItemForPhoto
            // 
            ItemForPhoto.Control = PhotoPictureEdit;
            ItemForPhoto.CustomizationFormText = "Photo";
            ItemForPhoto.Location = new Point(359, 0);
            ItemForPhoto.Name = "ItemForPhoto";
            ItemForPhoto.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2);
            ItemForPhoto.Size = new Size(141, 120);
            ItemForPhoto.Text = "Photo:";
            ItemForPhoto.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            emptySpaceItem1.Location = new Point(0, 120);
            emptySpaceItem1.MaxSize = new Size(0, 20);
            emptySpaceItem1.MinSize = new Size(10, 20);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(500, 20);
            emptySpaceItem1.SizeConstraintsType = XtraLayout.SizeConstraintsType.Custom;
            // 
            // ItemForAddress
            // 
            ItemForAddress.Control = AddressTextEdit;
            ItemForAddress.CustomizationFormText = "Address";
            ItemForAddress.Location = new Point(0, 140);
            ItemForAddress.Name = "ItemForAddress";
            ItemForAddress.Size = new Size(500, 24);
            ItemForAddress.Text = "Address";
            ItemForAddress.TextSize = new Size(63, 13);
            // 
            // ItemForCity
            // 
            ItemForCity.Control = CityTextEdit;
            ItemForCity.CustomizationFormText = "City";
            ItemForCity.Location = new Point(0, 164);
            ItemForCity.Name = "ItemForCity";
            ItemForCity.Size = new Size(243, 24);
            ItemForCity.Text = "City";
            ItemForCity.TextSize = new Size(63, 13);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            emptySpaceItem2.Location = new Point(0, 188);
            emptySpaceItem2.MaxSize = new Size(0, 20);
            emptySpaceItem2.MinSize = new Size(10, 20);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(500, 20);
            emptySpaceItem2.SizeConstraintsType = XtraLayout.SizeConstraintsType.Custom;
            // 
            // ItemForFullName
            // 
            ItemForFullName.Control = FullNameTextEdit;
            ItemForFullName.CustomizationFormText = "Full Name";
            ItemForFullName.Location = new Point(0, 48);
            ItemForFullName.Name = "ItemForFullName";
            ItemForFullName.Size = new Size(359, 24);
            ItemForFullName.Text = "Full Name";
            ItemForFullName.TextSize = new Size(63, 13);
            // 
            // ItemForHireDate
            // 
            ItemForHireDate.Control = HireDateDateEdit;
            ItemForHireDate.CustomizationFormText = "Hire Date";
            ItemForHireDate.Location = new Point(520, 48);
            ItemForHireDate.Name = "ItemForHireDate";
            ItemForHireDate.Size = new Size(475, 24);
            ItemForHireDate.Text = "Hire Date";
            ItemForHireDate.TextSize = new Size(63, 13);
            // 
            // ItemForBirthDate
            // 
            ItemForBirthDate.Control = BirthDateDateEdit;
            ItemForBirthDate.CustomizationFormText = "Birth Date";
            ItemForBirthDate.Location = new Point(0, 72);
            ItemForBirthDate.Name = "ItemForBirthDate";
            ItemForBirthDate.Size = new Size(359, 24);
            ItemForBirthDate.Text = "Birth Date";
            ItemForBirthDate.TextSize = new Size(63, 13);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            emptySpaceItem3.Location = new Point(0, 280);
            emptySpaceItem3.MaxSize = new Size(0, 20);
            emptySpaceItem3.MinSize = new Size(10, 20);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(995, 20);
            emptySpaceItem3.SizeConstraintsType = XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            emptySpaceItem4.Location = new Point(500, 0);
            emptySpaceItem4.MaxSize = new Size(20, 0);
            emptySpaceItem4.MinSize = new Size(20, 10);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new Size(20, 280);
            emptySpaceItem4.SizeConstraintsType = XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            emptySpaceItem5.Location = new Point(520, 72);
            emptySpaceItem5.MaxSize = new Size(0, 20);
            emptySpaceItem5.MinSize = new Size(10, 20);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new Size(475, 20);
            emptySpaceItem5.SizeConstraintsType = XtraLayout.SizeConstraintsType.Custom;
            // 
            // ItemForTitle
            // 
            ItemForTitle.Control = TitleTextEdit;
            ItemForTitle.CustomizationFormText = "Title";
            ItemForTitle.Location = new Point(0, 96);
            ItemForTitle.Name = "ItemForTitle";
            ItemForTitle.Size = new Size(243, 24);
            ItemForTitle.Text = "Title";
            ItemForTitle.TextSize = new Size(63, 13);
            // 
            // ItemForState
            // 
            ItemForState.Control = StateImageComboBoxEdit;
            ItemForState.CustomizationFormText = "State";
            ItemForState.Location = new Point(243, 164);
            ItemForState.Name = "ItemForState";
            ItemForState.Size = new Size(116, 24);
            ItemForState.Text = "State";
            ItemForState.TextAlignMode = XtraLayout.TextAlignModeItem.AutoSize;
            ItemForState.TextSize = new Size(26, 13);
            ItemForState.TextToControlDistance = 5;
            // 
            // ItemForZipCode
            // 
            ItemForZipCode.Control = ZipCodeTextEdit;
            ItemForZipCode.CustomizationFormText = "ZipCode";
            ItemForZipCode.Location = new Point(359, 164);
            ItemForZipCode.Name = "ItemForZipCode";
            ItemForZipCode.Size = new Size(141, 24);
            ItemForZipCode.Text = "ZIP code";
            ItemForZipCode.TextAlignMode = XtraLayout.TextAlignModeItem.AutoSize;
            ItemForZipCode.TextSize = new Size(42, 13);
            ItemForZipCode.TextToControlDistance = 5;
            // 
            // ItemForTasks
            // 
            ItemForTasks.Control = gridControlTasks;
            ItemForTasks.CustomizationFormText = "TASKS";
            ItemForTasks.Location = new Point(0, 300);
            ItemForTasks.Name = "ItemForTasks";
            ItemForTasks.Size = new Size(995, 256);
            ItemForTasks.Text = "Tasks";
            ItemForTasks.TextLocation = Utils.Locations.Top;
            ItemForTasks.TextSize = new Size(63, 13);
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataLayoutControl1);
            Name = "EmployeeView";
            Size = new Size(1015, 576);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrefixImageComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentImageComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusImageComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlEvaluations).EndInit();
            ((System.ComponentModel.ISupportInitialize)evaluationsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvEvaluations).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomePhoneTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)MobilePhoneTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CityTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StateImageComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZipCodeTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FullNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)HireDateDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)HireDateDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitleTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignedTasksBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)autoGeneratedGroup0).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPrefix).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEvaluations).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForHomePhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForMobilePhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCity).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFullName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForHireDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForBirthDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForState).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForZipCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private TextEdit FirstNameTextEdit;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.BarButtonItem barButtonItem2;
        private XtraBars.BarButtonItem barButtonItem3;
        private XtraBars.BarButtonItem barButtonItem4;
        private XtraBars.BarButtonItem barButtonItem5;
        private XtraBars.BarButtonItem barButtonItem6;
        private XtraBars.BarSubItem barSubItem1;
        private XtraBars.BarButtonItem barButtonItem7;
        private XtraBars.BarButtonItem barButtonItem8;
        private XtraBars.BarButtonItem barButtonItem9;
        private XtraBars.BarButtonItem barButtonItem10;
        private XtraBars.BarButtonItem barButtonItem11;
        private XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private XtraBars.BarButtonItem barButtonItem12;
        private XtraBars.BarButtonItem barButtonItem13;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private TextEdit LastNameTextEdit;
        private ImageComboBoxEdit PrefixImageComboBoxEdit;
        private ImageComboBoxEdit DepartmentImageComboBoxEdit;
        private ImageComboBoxEdit StatusImageComboBoxEdit;
        private XtraGrid.GridControl gridControlEvaluations;
        private XtraGrid.Views.Grid.GridView gvEvaluations;
        private XtraGrid.Columns.GridColumn colCreatedOn;
        private XtraGrid.Columns.GridColumn colSubject;
        private XtraGrid.Columns.GridColumn colCreatedBy;
        private ButtonEdit HomePhoneTextEdit;
        private ButtonEdit MobilePhoneTextEdit;
        private ButtonEdit EmailTextEdit;
        private PictureEdit PhotoPictureEdit;
        private TextEdit AddressTextEdit;
        private TextEdit CityTextEdit;
        private ImageComboBoxEdit StateImageComboBoxEdit;
        private TextEdit ZipCodeTextEdit;
        private TextEdit FullNameTextEdit;
        private DateEdit HireDateDateEdit;
        private DateEdit BirthDateDateEdit;
        private TextEdit TitleTextEdit;
        private XtraGrid.GridControl gridControlTasks;
        private XtraGrid.Views.Grid.GridView gvTasks;
        private XtraGrid.Columns.GridColumn colPriority;
        private XtraGrid.Columns.GridColumn colDueDate;
        private XtraGrid.Columns.GridColumn colSubject1;
        private XtraGrid.Columns.GridColumn colDescription;
        private XtraGrid.Columns.GridColumn colCompletion;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private XtraLayout.LayoutControlGroup autoGeneratedGroup0;
        private XtraLayout.LayoutControlItem ItemForFirstName;
        private XtraLayout.LayoutControlItem ItemForLastName;
        private XtraLayout.LayoutControlItem ItemForPrefix;
        private XtraLayout.LayoutControlItem ItemForDepartment;
        private XtraLayout.LayoutControlItem ItemForStatus;
        private XtraLayout.LayoutControlItem ItemForEvaluations;
        private XtraLayout.LayoutControlItem ItemForHomePhone;
        private XtraLayout.LayoutControlItem ItemForMobilePhone;
        private XtraLayout.LayoutControlItem ItemForEmail;
        private XtraLayout.LayoutControlItem ItemForPhoto;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem ItemForAddress;
        private XtraLayout.LayoutControlItem ItemForCity;
        private XtraLayout.LayoutControlItem ItemForState;
        private XtraLayout.LayoutControlItem ItemForZipCode;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem ItemForFullName;
        private XtraLayout.LayoutControlItem ItemForHireDate;
        private XtraLayout.LayoutControlItem ItemForBirthDate;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem5;
        private XtraLayout.LayoutControlItem ItemForTitle;
        private XtraLayout.LayoutControlItem ItemForTasks;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource evaluationsBindingSource;
        private System.Windows.Forms.BindingSource assignedTasksBindingSource;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
