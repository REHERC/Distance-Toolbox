using System;
using System.Threading;
using System.Windows.Forms;
using Photon.Forms;

namespace Photon
{
    static class Program
    {
        private static SplashForm SplashScreen;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread SplashScreenThread = new Thread(new ThreadStart(delegate
            {
                SplashScreen = new SplashForm();
                Application.Run(SplashScreen);
            }));

            SplashScreenThread.SetApartmentState(ApartmentState.STA);
            SplashScreenThread.Start();

            Globals.Variables.MainForm = new MainForm();
            Globals.Variables.MainForm.Shown += MainFormLoad;

            Globals.Variables.AppPath = Application.StartupPath;

            Globals.Settings.Initialize();
            
            Application.Run(Globals.Variables.MainForm);
        }



        static void MainFormLoad(object sender, EventArgs e)
        {
            if (SplashScreen == null) return;

            SplashScreen.Invoke(new Action(SplashScreen.Close));
            SplashScreen.Dispose();
            SplashScreen = null;

            MainForm form = (MainForm)sender;

            form.Select();
            form.Focus();
            form.BringToFront();
        }
    }
}
