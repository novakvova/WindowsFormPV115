using _14_CreateDialogWinForms.Services;
using System;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SeedData.Init();
            Application.Run(new HomeForm());
            //Application.Run(new LoginForm());
        }
    }
}