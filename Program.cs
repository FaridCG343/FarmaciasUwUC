using FarmaciasUwU.App.Models;
using FarmaciasUwU.App.Views;
using FarmaciasUwU.Views;

namespace FarmaciasUwU
{
    internal static class Program
    {
        public static Usuario? user;
        public static FormPOS? formPOS;
        public static FormAdminMenu? adminForm;
        public static Form? formGestion;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }
    }
}