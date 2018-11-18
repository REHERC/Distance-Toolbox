using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Photon
{
    public static class ColorExtensions
    {
        public static Color Lerp(this Color a, Color b, float t)
        {
            return Color.FromArgb
            (
                (int)Math.Round(a.A + (b.A - a.A) * t),
                (int)Math.Round(a.R + (b.R - a.R) * t),
                (int)Math.Round(a.G + (b.G - a.G) * t),
                (int)Math.Round(a.B + (b.B - a.B) * t)
            );
        }

        public static Color Multiply(this Color c, float v)
        {
            return Color.FromArgb
            (
                (int)Math.Round(Math.Min(Math.Max(c.A * v, 0), 255)),
                (int)Math.Round(Math.Min(Math.Max(c.R * v, 0), 255)),
                (int)Math.Round(Math.Min(Math.Max(c.G * v, 0), 255)),
                (int)Math.Round(Math.Min(Math.Max(c.B * v, 0), 255))
            );
        }

        public static Color MultiplyNoAlpha(this Color c, float v)
        {
            return Color.FromArgb
            (
                c.A,
                (int)Math.Round(Math.Min(Math.Max(c.R * v, 0), 255)),
                (int)Math.Round(Math.Min(Math.Max(c.G * v, 0), 255)),
                (int)Math.Round(Math.Min(Math.Max(c.B * v, 0), 255))
            );
        }

        public static Color Transparency(this Color c, int t)
        {
            t = Math.Min(Math.Max(t, 0), 255);
            
            return Color.FromArgb
            (
                t,
                c.R,
                c.G,
                c.B
            );
        }

        public static string Serialize(this Color c)
        {
            return $@"{c.A};{c.R};{c.G};{c.B}";
        }

        public static Color Deserialize(string serial)
        {
            int a;
            int r;
            int g;
            int b;

            string[] splits = serial.Split(';');

            a = int.Parse(splits[0]);
            r = int.Parse(splits[1]);
            g = int.Parse(splits[2]);
            b = int.Parse(splits[3]);

            return Color.FromArgb(a,r,g,b);
        }
    }
}
