using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photon.GUI
{
    class PhotonTrayButton : Button
    {
        public PhotonTrayButton()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });
        }

        private ControlState State = ControlState.Normal;

        protected override void OnMouseEnter(EventArgs e)
        {
            State = ControlState.Hover;
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            State = ControlState.Normal;
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                State = ControlState.Pressed;
            }
            base.OnMouseDown(mevent);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                State = ControlState.Hover;
            }
            base.OnMouseUp(mevent);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.Clear(Color.White);

            Brush FillBrush;
            Brush TextBrush;

            if (Enabled)
            {
                switch (State)
                {
                    case ControlState.Normal:
                        FillBrush = new SolidBrush(this.BackColor);
                        TextBrush = new SolidBrush(Globals.Colors.CONTROL_Lighter);
                        break;
                    case ControlState.Hover:
                        FillBrush = new SolidBrush(this.BackColor.MultiplyNoAlpha(1.2f));
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    case ControlState.Pressed:
                        FillBrush = new SolidBrush(this.BackColor.MultiplyNoAlpha(0.9f));
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    default:
                        FillBrush = new SolidBrush(this.BackColor.MultiplyNoAlpha(1.2f));
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                }
            }
            else
            {
                FillBrush = new SolidBrush(this.BackColor);
                TextBrush = new SolidBrush(this.BackColor.MultiplyNoAlpha(0.8f));
            }

            e.Graphics.FillRectangle(FillBrush, bounds);
            e.Graphics.DrawString(this.Text, this.Font, TextBrush, bounds, sf);

        }
    }
}
