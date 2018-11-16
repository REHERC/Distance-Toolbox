using System;
using System.Windows.Threading;

namespace Photon
{
    public static class Tools
    {
        public static void Wait(double Duration, Action Continue)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(Duration);
            timer.Tick += delegate(object sender, EventArgs e) {
                Continue();
                timer.Stop();
            };
            timer.Start();
        }
    }
}
