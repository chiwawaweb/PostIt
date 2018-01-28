using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostIt
{
    static class Program
    {
        class App : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
        {
            public App()
            {
                IsSingleInstance = true;
            }

            protected override void OnCreateMainForm()
            {
                MainForm = new Forms.MainForm();
            }
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var app = new App();
            app.Run(args);
            //Application.Run(new Forms.MainForm());
        }
    }
}
