using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsRentSystem.DesktopUI
{
    public static class Globals
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["RentSysConnectionString"].ConnectionString;
    }

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

            var loginForm = new LoginWindow();
            if (loginForm.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (loginForm.correctLogin)
            {
                Application.Run(new MainWindow());
            }
        }
    }
}
