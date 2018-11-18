using Photon.GUI.ToolPage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Photon
{
    public static class Tools
    {
        public static void Wait(double Duration, Action Continue)
        {
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(Duration)
            };
            timer.Tick += delegate(object sender, EventArgs e) {
                Continue();
                timer.Stop();
            };
            timer.Start();
        }

        public static bool IsRunAsAdmin()
        {
            var Principle = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return Principle.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool Elevate(string arguments)
        {
            var SelfProc = new ProcessStartInfo
            {
                UseShellExecute = true,
                Arguments = arguments,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process.Start(SelfProc);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static ToolPage PageFromType(string id)
        {
            List<Type> pagetypes = VType.GetDerivedTypes(typeof(ToolPage), Assembly.GetExecutingAssembly());

            foreach (Type pagetype in pagetypes)
            {
                ToolPage instance = Activator.CreateInstance(pagetype) as ToolPage;

                if (instance.PageName == id)
                {
                    return instance;
                }

                instance.Dispose();
            }
            return null;
        }
    }
}
