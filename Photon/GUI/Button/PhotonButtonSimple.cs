using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photon.GUI
{
    public class PhotonButtonSimple : Button
    {
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
            Rectangle bounds = new Rectangle(0,0,this.Width,this.Height);

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
                        FillBrush = new SolidBrush(Globals.Colors.CONTROL_FILL_Light);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    case ControlState.Hover:
                        FillBrush = new SolidBrush(Globals.Colors.CONTROL_FILL_Dark);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    case ControlState.Pressed:
                        FillBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        TextBrush = new SolidBrush(Globals.Colors.CONTROL_FILL_Light);
                        break;
                    default:
                        FillBrush = new SolidBrush(Globals.Colors.CONTROL_FILL_Light);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                }
            }
            else
            {
                FillBrush = new SolidBrush(Globals.Colors.CONTROL_FILL_Light);
                TextBrush = new SolidBrush(Globals.Colors.CONTROL_FILL_Dark);
            }

            e.Graphics.Clear(Color.Transparent);
            e.Graphics.FillRectangle(FillBrush, bounds);
            e.Graphics.DrawString(this.Text,this.Font,TextBrush, bounds, sf);

        }
    }
}
