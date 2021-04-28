using System;
using System.Windows.Forms;

namespace W32RegActionParser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MainForm form = new MainForm())
            {
                Application.Run(form);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
