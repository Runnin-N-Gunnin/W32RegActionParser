namespace W32RegActionParser
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditSkinRGroup = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.barEditFileFormat = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.lblNumEntries = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnRClickCopyRow = new DevExpress.XtraBars.BarButtonItem();
            this.btnRClickCopyCell = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageCollExport = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollCol = new DevExpress.Utils.ImageCollection(this.components);
            this.popupMenuRClick = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuRClick)).BeginInit();
            this.SuspendLayout();
            // 
            // bManager
            // 
            this.bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.bManager.DockControls.Add(this.barDockControlTop);
            this.bManager.DockControls.Add(this.barDockControlBottom);
            this.bManager.DockControls.Add(this.barDockControlLeft);
            this.bManager.DockControls.Add(this.barDockControlRight);
            this.bManager.Form = this;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLoad,
            this.btnClear,
            this.barStaticItem1,
            this.barEditSkinRGroup,
            this.barEditFileFormat,
            this.lblStatus,
            this.btnExport,
            this.lblNumEntries,
            this.btnRClickCopyRow,
            this.btnRClickCopyCell});
            this.bManager.MainMenu = this.bar2;
            this.bManager.MaxItemId = 10;
            this.bManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemComboBox1});
            this.bManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEditSkinRGroup, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditFileFormat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Load";
            this.btnLoad.Id = 0;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.LargeImage")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnClear
            // 
            this.btnClear.Caption = "Clear";
            this.btnClear.Enabled = false;
            this.btnClear.Id = 1;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.LargeImage")));
            this.btnClear.Name = "btnClear";
            this.btnClear.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClear_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Export";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditSkinRGroup
            // 
            this.barEditSkinRGroup.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditSkinRGroup.Caption = "Theme";
            this.barEditSkinRGroup.Edit = this.repositoryItemRadioGroup1;
            this.barEditSkinRGroup.EditValue = 0;
            this.barEditSkinRGroup.EditWidth = 110;
            this.barEditSkinRGroup.Id = 3;
            this.barEditSkinRGroup.Name = "barEditSkinRGroup";
            this.barEditSkinRGroup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditSkinRGroup.EditValueChanged += new System.EventHandler(this.barEditSkinRGroup_EditValueChanged);
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Columns = 2;
            this.repositoryItemRadioGroup1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRadioGroup1.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near;
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Light"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Dark")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // barEditFileFormat
            // 
            this.barEditFileFormat.Caption = "barEditItem2";
            this.barEditFileFormat.Edit = this.repositoryItemComboBox1;
            this.barEditFileFormat.EditValue = "TXT";
            this.barEditFileFormat.EditWidth = 50;
            this.barEditFileFormat.Enabled = false;
            this.barEditFileFormat.Id = 4;
            this.barEditFileFormat.Name = "barEditFileFormat";
            this.barEditFileFormat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.barEditFileFormat.EditValueChanged += new System.EventHandler(this.barEditFileFormat_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "TXT",
            "CSV",
            "XLS",
            "XLSX"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Id = 6;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.LargeImage")));
            this.btnExport.Name = "btnExport";
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblNumEntries)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblStatus
            // 
            this.lblStatus.Caption = "Idle";
            this.lblStatus.Id = 5;
            this.lblStatus.Name = "lblStatus";
            // 
            // lblNumEntries
            // 
            this.lblNumEntries.Id = 7;
            this.lblNumEntries.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNumEntries.ItemAppearance.Normal.Options.UseFont = true;
            this.lblNumEntries.Name = "lblNumEntries";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1113, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 597);
            this.barDockControlBottom.Manager = this.bManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1113, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.bManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 569);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1113, 28);
            this.barDockControlRight.Manager = this.bManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 569);
            // 
            // btnRClickCopyRow
            // 
            this.btnRClickCopyRow.Caption = "Copy Selected Row(s) (CTRL+C)";
            this.btnRClickCopyRow.Id = 8;
            this.btnRClickCopyRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRClickCopyRow.ImageOptions.Image")));
            this.btnRClickCopyRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRClickCopyRow.ImageOptions.LargeImage")));
            this.btnRClickCopyRow.Name = "btnRClickCopyRow";
            this.btnRClickCopyRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRClickCopyRow_ItemClick);
            // 
            // btnRClickCopyCell
            // 
            this.btnRClickCopyCell.Caption = "Copy Cell (CTRL+C)";
            this.btnRClickCopyCell.Id = 9;
            this.btnRClickCopyCell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRClickCopyCell.ImageOptions.Image")));
            this.btnRClickCopyCell.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRClickCopyCell.ImageOptions.LargeImage")));
            this.btnRClickCopyCell.Name = "btnRClickCopyCell";
            this.btnRClickCopyCell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRClickCopyCell_ItemClick);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 28);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.bManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1113, 569);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView_PopupMenuShowing);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView_RowCountChanged);
            // 
            // imageCollExport
            // 
            this.imageCollExport.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollExport.ImageStream")));
            this.imageCollExport.Images.SetKeyName(0, "TXT.png");
            this.imageCollExport.Images.SetKeyName(1, "CSV.png");
            this.imageCollExport.Images.SetKeyName(2, "XLS.png");
            this.imageCollExport.Images.SetKeyName(3, "XLSX.png");
            // 
            // imageCollCol
            // 
            this.imageCollCol.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollCol.ImageStream")));
            this.imageCollCol.Images.SetKeyName(0, "tag_16x16.png");
            this.imageCollCol.Images.SetKeyName(1, "text_16x16.png");
            this.imageCollCol.Images.SetKeyName(2, "comment_16x16.png");
            this.imageCollCol.Images.SetKeyName(3, "sort_16x16.png");
            this.imageCollCol.Images.SetKeyName(4, "textthatcontains_16x16.png");
            this.imageCollCol.Images.SetKeyName(5, "showallfieldresults_16x16.png");
            this.imageCollCol.Images.SetKeyName(6, "Key2.png");
            this.imageCollCol.Images.SetKeyName(7, "textbox2_16x16.png");
            this.imageCollCol.Images.SetKeyName(8, "reg_1616.png");
            this.imageCollCol.Images.SetKeyName(9, "createmodeldifferences_16x16.png");
            this.imageCollCol.Images.SetKeyName(10, "selectdatamember_16x16.png");
            this.imageCollCol.Images.SetKeyName(11, "tableofcontent_16x16.png");
            this.imageCollCol.Images.SetKeyName(12, "servermode_16x16.png");
            this.imageCollCol.Images.SetKeyName(13, "version_16x16.png");
            // 
            // popupMenuRClick
            // 
            this.popupMenuRClick.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRClickCopyCell),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRClickCopyRow)});
            this.popupMenuRClick.Manager = this.bManager;
            this.popupMenuRClick.Name = "popupMenuRClick";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 619);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.IconOptions.Image = global::W32RegActionParser.Properties.Resources.reg22;
            this.Name = "MainForm";
            this.Text = "W32RegActionParser";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuRClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnClear;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditSkinRGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarEditItem barEditFileFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.Utils.ImageCollection imageCollExport;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraBars.BarStaticItem lblNumEntries;
        private DevExpress.Utils.ImageCollection imageCollCol;
        private DevExpress.XtraBars.BarButtonItem btnRClickCopyRow;
        private DevExpress.XtraBars.PopupMenu popupMenuRClick;
        private DevExpress.XtraBars.BarButtonItem btnRClickCopyCell;
    }
}

