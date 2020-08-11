using System;
using System.Threading;
using System.Windows.Forms;
using XboxEepromEditor.Forms;

namespace XboxEepromEditor
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
            Application.ThreadException += GlobalExceptionHandler;
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Handles uncaught exceptions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void GlobalExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            // TODO: log full messages and truncate messagebox contents to first 10 lines
            MessageBox.Show(e.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
