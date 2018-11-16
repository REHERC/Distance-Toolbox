using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photon.GUI
{
    public class PhotonHeaderLabel : Label
    {
        public PhotonHeaderLabel()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle safebounds = bounds.Padding((int)Math.Round(this.Font.Size * 1.5), 0, 0, 0);

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Near;

            e.Graphics.Clear(BackColor);

            Brush FillBrush;
            Brush LineBrush;
            Brush TextBrush;

            if (Enabled)
            {
                FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Medium);
                LineBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Dark);
                TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
            }
            else
            {
                FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Dark);
                LineBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Darker);
                TextBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Dark);
            }

            e.Graphics.FillRectangle(FillBrush, bounds);
            e.Graphics.FillRectangle(LineBrush, 0, 0, this.Font.Size, Height);
            e.Graphics.DrawString(this.Text, this.Font, TextBrush, safebounds, sf);
        }
    }
}
