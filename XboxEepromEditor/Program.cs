using Serilog;
using System;
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
            Log.Logger = new LoggerConfiguration().WriteTo.File("XboxEepromEditor.log").CreateLogger();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Handles uncaught exceptions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Log.Error(e.ExceptionObject as Exception, "Unhandled exception!");
            Log.CloseAndFlush();

            MessageBox.Show("Please check log for additional information.",
                "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
