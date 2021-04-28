using System;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace W32RegActionParser
{
    public class ExportManager
    {
        private string _name = @"Export";
        private string directory = $@"{Application.StartupPath}\Exports\";
        private ExportFormat _exFormat;
        string strTemplate;
        string dtHolder = DateTime.Now.ToString("yyyyMMddTHHmm"); // ISO 8601
        string exportExt = string.Empty;
        string path = string.Empty;

        public ExportManager(ExportFormat exFormat)
        {
            _exFormat = exFormat;

            if (!directory.EndsWith("\\"))
            {
                directory += "\\";
            }

            strTemplate = $@"W32RegActionParser-{_name}-";

            switch (exFormat)
            {
                case ExportFormat.Txt:
                    exportExt = ".txt";
                    _exFormat = ExportFormat.Txt;
                    break;
                case ExportFormat.Csv:
                    exportExt = ".csv";
                    _exFormat = ExportFormat.Csv;
                    break;
                case ExportFormat.Xls:
                    exportExt = ".xls";
                    _exFormat = ExportFormat.Xls;
                    break;
                case ExportFormat.Xlsx:
                    exportExt = ".xlsx";
                    _exFormat = ExportFormat.Xlsx;
                    break;
            }

            path = directory + strTemplate + dtHolder + exportExt;
        }

        public void ExportGridToFile(GridControl gridCtrl)
        {
            switch (_exFormat)
            {
                case ExportFormat.Txt:
                    gridCtrl.ExportToText(path);
                    break;
                case ExportFormat.Csv:
                    gridCtrl.ExportToCsv(path);
                    break;
                case ExportFormat.Xls:
                    gridCtrl.ExportToXls(path);
                    break;
                case ExportFormat.Xlsx:
                    gridCtrl.ExportToXlsx(path);
                    break;
            }
        }
    }
}
