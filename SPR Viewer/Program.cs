using System;
using System.Windows.Forms;

namespace SPR_Viewer
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // https://stackoverflow.com/questions/56642/loader-lock-error
            Application.Run(new Main());
        }
    }
}