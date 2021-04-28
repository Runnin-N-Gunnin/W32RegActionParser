using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Management;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace W32RegActionParser
{
    public class ActionView
    {
        private GridControl _gridCtrl;
        private GridView _gridView;
        private BarStaticItem _lblStatus;
        private BarStaticItem _lblNumEntries;

        private BindingList<ActionEntry> actionEntries = new BindingList<ActionEntry>();

        private BackgroundWorker wRActionWorker;
        private StopwatchController stopWatch = new StopwatchController();

        private ImageCollection _imageCollection;

        public ActionView(GridControl gridCtrl, BarStaticItem lblStatus, BarStaticItem lblNumEntries, ImageCollection imageCollection)
        {
            _gridCtrl = gridCtrl;
            _gridView = gridCtrl.MainView as GridView;

            _lblStatus = lblStatus;
            _lblNumEntries = lblNumEntries;
            _imageCollection = imageCollection;
        }

        public void Load()
        {
            _lblStatus.Caption = @"Loading.. Please Wait.";
            _gridCtrl.UseWaitCursor = true;

            wRActionWorker = new BackgroundWorker();
            wRActionWorker.DoWork += wRActionWorker_DoWork;
            wRActionWorker.RunWorkerCompleted += wRActionWorker_RunWorkerCompleted;
            stopWatch.Start();
            wRActionWorker.RunWorkerAsync();
        }

        private void wRActionWorker_DoWork(object sender, DoWorkEventArgs e) => Query();

        private void wRActionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _gridCtrl.UseWaitCursor = false;
            _gridCtrl.DataSource = actionEntries;
            SetColIcons();
            SetColToolTipText();
            UpdateNumTotalEntries(actionEntries.Count);
            UpdateStatus("Finished");
        }

        public string GetSelectedValues()
        {
            if (_gridView.SelectedRowsCount == 0) return "";

            const string CellDelimiter = "\t";
            const string LineDelimiter = "\r\n";
            string result = "";

            for (int i = _gridView.SelectedRowsCount - 1; i >= 0; i--)
            {
                int row = _gridView.GetSelectedRows()[i];
                for (int j = 0; j < _gridView.VisibleColumns.Count; j++)
                {
                    result += _gridView.GetRowCellDisplayText(row, _gridView.VisibleColumns[j]);
                    if (j != _gridView.VisibleColumns.Count - 1)
                        result += CellDelimiter;
                }
                if (i != 0)
                    result += LineDelimiter;
            }
            return result;
        }

        private void SetColIcons()
        {
            for (int i = 0; i != _imageCollection.Images.Count; i++)
            {
                _gridView.Columns[i].Image = _imageCollection.Images[i];
            }
        }

        private void SetColToolTipText()
        {
            _gridView.Columns[0].ToolTip = Properties.Resources.Col0DescriptionText;
            _gridView.Columns[1].ToolTip = Properties.Resources.Col1DescriptionText;
            _gridView.Columns[2].ToolTip = Properties.Resources.Col2DescriptionText;
            _gridView.Columns[3].ToolTip = Properties.Resources.Col3DescriptionText;
            _gridView.Columns[4].ToolTip = Properties.Resources.Col4DescriptionText;
            _gridView.Columns[5].ToolTip = Properties.Resources.Col5DescriptionText;
            _gridView.Columns[6].ToolTip = Properties.Resources.Col6DescriptionText;
            _gridView.Columns[7].ToolTip = Properties.Resources.Col7DescriptionText;
            _gridView.Columns[8].ToolTip = Properties.Resources.Col8DescriptionText;
            _gridView.Columns[9].ToolTip = Properties.Resources.Col9DescriptionText;
            _gridView.Columns[10].ToolTip = Properties.Resources.Col10DescriptionText;
            _gridView.Columns[11].ToolTip = Properties.Resources.Col11DescriptionText;
            _gridView.Columns[12].ToolTip = Properties.Resources.Col12DescriptionText;
            _gridView.Columns[13].ToolTip = Properties.Resources.Col13DescriptionText;
        }

        public void Clear()
        {
            actionEntries.Clear();

            _lblStatus.Caption = @"Idle";
        }

        private void Query()
        {
            try
            {
                string scope = "\\\\.\\root\\CIMV2";
                string query = "SELECT ActionID, Caption, Description, Direction, EntryName, EntryValue, key, Name, Registry, Root, SoftwareElementID, SoftwareElementState, TargetOperatingSystem, Version FROM Win32_RegistryAction";
                ManagementObjectCollection regObjCollection = new ManagementObjectSearcher(new ManagementScope(scope), (ObjectQuery)new SelectQuery(query)).Get();

                foreach (var mgtObject in regObjCollection)
                {
                    ActionEntry actEntry = new ActionEntry();

                    actEntry.ActionID = mgtObject["ActionID"] != null ? mgtObject["ActionID"].ToString() : string.Empty;
                    actEntry.Caption = mgtObject["Caption"] != null ? mgtObject["Caption"].ToString() : string.Empty;
                    actEntry.Description = mgtObject["Description"] != null ? mgtObject["Description"].ToString() : string.Empty;
                    actEntry.Direction = mgtObject["Direction"] != null ? mgtObject["Direction"].ToString() : string.Empty;
                    actEntry.EntryName = mgtObject["EntryName"] != null ? mgtObject["EntryName"].ToString() : string.Empty;
                    actEntry.EntryValue = mgtObject["EntryValue"] != null ? mgtObject["EntryValue"].ToString() : string.Empty;
                    actEntry.Key = mgtObject["key"] != null ? mgtObject["key"].ToString() : string.Empty;
                    actEntry.Name = mgtObject["Name"] != null ? mgtObject["Name"].ToString() : string.Empty;
                    actEntry.Registry = mgtObject["Registry"] != null ? mgtObject["Registry"].ToString() : string.Empty;
                    actEntry.Root = mgtObject["Root"] != null ? mgtObject["Root"].ToString() : string.Empty;
                    actEntry.SoftwareElementID = mgtObject["SoftwareElementID"] != null ? mgtObject["SoftwareElementID"].ToString() : string.Empty;
                    actEntry.SoftwareElementState = mgtObject["SoftwareElementState"] != null ? mgtObject["SoftwareElementState"].ToString() : string.Empty;
                    actEntry.TargetOperatingSystem = mgtObject["TargetOperatingSystem"] != null ? mgtObject["TargetOperatingSystem"].ToString() : string.Empty;
                    actEntry.Version = mgtObject["Version"] != null ? mgtObject["Version"].ToString() : string.Empty;

                    actionEntries.Add(actEntry);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Source);
                Debug.WriteLine(e.StackTrace);
                Debug.WriteLine(e.Message);
            }
        }

        private void UpdateStatus(string s)
        {
            stopWatch.Stop();
            _lblStatus.Caption = $@"{s} ({stopWatch.Text})";
        }

        private void UpdateNumTotalEntries(int e)
        {
            _lblNumEntries.Caption = $@"Entries: {e}";
        }
    }
}
