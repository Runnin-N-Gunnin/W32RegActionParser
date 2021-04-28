using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraPrinting;

namespace W32RegActionParser
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private ActionView actionView;
        private ExportManager exportMgr;
        private ExportFormat _exportFormat = ExportFormat.Csv;

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetSkin(Properties.Settings.Default.SkinIndex);
            barEditFileFormat.EditValue = "CSV";
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLoad.Enabled = false;
            actionView = new ActionView(gridControl, lblStatus, lblNumEntries, imageCollCol);
            actionView.Load();
        }

        private void btnClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionView.Clear();
            btnExport.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            exportMgr = new ExportManager(_exportFormat);
            exportMgr.ExportGridToFile(gridControl);
        }

        private void barEditSkinRGroup_EditValueChanged(object sender, EventArgs e) => SetSkin((int)barEditSkinRGroup.EditValue);

        private void SetSkin(int skinIndex)
        {
            string skinName = null;

            if (skinIndex == 0)
            {
                skinName = Properties.Settings.Default.LightTheme;

            }
            else if (skinIndex == 1)
            {
                skinName = Properties.Settings.Default.DarkTheme;
            }

            try
            {
                UserLookAndFeel.Default.SetSkinStyle(skinName);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                UserLookAndFeel.Default.SetSkinStyle("Basic");
            }

            if ((int)barEditSkinRGroup.EditValue != skinIndex) barEditSkinRGroup.EditValue = skinIndex;
            SetSkinIndex(skinIndex);
        }

        private void SetSkinIndex(int index)
        {
            switch (index)
            {
                case 0:
                    Properties.Settings.Default.SkinIndex = 0;
                    break;
                case 1:
                    Properties.Settings.Default.SkinIndex = 1;
                    break;
            }

            Properties.Settings.Default.Save();
        }

        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            if (gridView.RowCount > 0)
            {
                btnExport.Enabled = true;
                btnClear.Enabled = true;
                barEditFileFormat.Enabled = true;
            }
            else
            {
                btnExport.Enabled = false;
                btnClear.Enabled = false;
                barEditFileFormat.Enabled = false;
            }
        }

        private void barEditFileFormat_EditValueChanged(object sender, EventArgs e)
        {
            int imageIndex = 0;
            switch (barEditFileFormat.EditValue.ToString())
            {
                case "TXT":
                    imageIndex = 0;
                    _exportFormat = ExportFormat.Txt;
                    break;
                case "CSV":
                    imageIndex = 1;
                    _exportFormat = ExportFormat.Csv;
                    break;
                case "XLS":
                    imageIndex = 2;
                    _exportFormat = ExportFormat.Xls;
                    break;
                case "XLSX":
                    imageIndex = 3;
                    _exportFormat = ExportFormat.Xlsx;
                    break;
            }

            barEditFileFormat.ImageOptions.Image = imageCollExport.Images[imageIndex];
        }

        private void btnRClickCopyRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => Clipboard.SetText(actionView.GetSelectedValues());
        private void btnRClickCopyCell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => Clipboard.SetText(gridView.GetFocusedValue().ToString());

        private void gridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (gridView.RowCount == 0) return;

            if (e.HitInfo.InRow)
            {
                try
                {
                    Point p2 = MousePosition;
                    popupMenuRClick.ShowPopup(p2);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    Debug.WriteLine(exception.Source);
                    Debug.WriteLine(exception.StackTrace);
                }
            }
        }


    }
}
