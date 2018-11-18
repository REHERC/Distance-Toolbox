using System;
using System.Drawing;

namespace Photon.Globals
{
    public static class Colors
    {
        //public static Color PRIMARY_Main = Color.FromArgb(255, 255, 160, 0);
        public static Color PRIMARY_Main = Color.FromArgb(255, 36, 109, 145);

        public static Color CONTROL_Lighter = Color.White;
        public static Color CONTROL_Light = Color.FromArgb(255, 250, 250, 250);
        public static Color CONTROL_Medium = Color.FromArgb(255, 200, 200, 200);
        public static Color CONTROL_Dark = Color.FromArgb(255, 100, 100, 100);

        public static Color GRAYSCALE_Light = Color.White;
        public static Color GRAYSCALE_Medium = Color.WhiteSmoke;
        public static Color GRAYSCALE_Dark = Color.FromArgb(255, 235, 235, 235);
        public static Color GRAYSCALE_Darker = Color.FromArgb(255, 210, 210, 210);


        public static event Action OnColorsUpdated;

        public static void UpdateColors()
        {
            OnColorsUpdated.Invoke();
        }
    }
}
