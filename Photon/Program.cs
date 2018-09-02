using System;
using System.Windows.Forms;
using Photon.Forms;

namespace Photon
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
            Globals.Variables.MainForm = new MainForm();
            Application.Run(Globals.Variables.MainForm);
        }
    }
}
