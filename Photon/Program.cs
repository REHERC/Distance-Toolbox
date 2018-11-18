using System;
using System.Threading;
using System.Windows.Forms;
using Photon.Forms;
using CommandLine;
using Photon.GUI.ToolPage;

namespace Photon
{
    static class Program
    {
        private static SplashForm SplashScreen;
        public static CommandLineArguments Arguments;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Parser.Default.ParseArguments<CommandLineArguments>(args).WithParsed<CommandLineArguments>(value => {
                Arguments = value;
            });
            
            //MessageBox.Show(Parser.Default.FormatCommandLine<CommandLineArguments>(Arguments));

            if (!Arguments.Splash)
            {
                Thread SplashScreenThread = new Thread(new ThreadStart(delegate
                {
                    SplashScreen = new SplashForm();
                    Application.Run(SplashScreen);
                }));
                
                SplashScreenThread.SetApartmentState(ApartmentState.STA);
                SplashScreenThread.Start();
            }


            Globals.Variables.MainForm = new MainForm();
            Globals.Variables.MainForm.Shown += MainFormLoad;

            Globals.Variables.AppPath = Application.StartupPath;

            Globals.Settings.Initialize();
            
            Application.Run(Globals.Variables.MainForm);
        }



        static void MainFormLoad(object sender, EventArgs e)
        {
            if (SplashScreen != null) {
                SplashScreen.Invoke(new Action(SplashScreen.Close));
                SplashScreen.Dispose();
                SplashScreen = null;
            }

            MainForm form = (MainForm)sender;
            
            form.BringToFront();
            form.Activate();

            if (Arguments.Setwindow)
            {
                form.Left = Arguments.Position_x;
                form.Top = Arguments.Position_y;
                form.Width = Arguments.Size_w;
                form.Height = Arguments.Size_h;

                form.WindowState = (FormWindowState)Arguments.Window_s;
            }
        }
    }
}
