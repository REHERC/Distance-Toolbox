using System.Drawing;

namespace Photon
{
    public static class RectangleExtensions
    {
        public static Rectangle Padding(this Rectangle rect, int px, int py, int sx, int sy)
        {
            return new Rectangle(rect.X + px,rect.Y + py,rect.Width - px + sx,rect.Height - py + sy);
        }
    }
}
