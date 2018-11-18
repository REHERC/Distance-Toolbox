using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photon.GUI
{
    public class PhotonButton : Button
    {
        public PhotonButton()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                Invalidate();
                Update();
                Refresh();
            });
        }
        
        private ControlState State = ControlState.Normal;

        protected override void OnMouseEnter(EventArgs e)
        {
            State = ControlState.Hover;
            base.OnMouseEnter(e);
            Invalidate();
            Update();
            Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            State = ControlState.Normal;
            base.OnMouseLeave(e);
            Invalidate();
            Update();
            Refresh();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                State = ControlState.Pressed;
            }
            base.OnMouseDown(mevent);
            Invalidate();
            Update();
            Refresh();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                State = ControlState.Hover;
            }
            base.OnMouseUp(mevent);
            Invalidate();
            Update();
            Refresh();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
            Update();
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0,0,this.Width,this.Height);
            Rectangle safebounds = bounds.Padding(10, 0, 0, 0);

            StringFormat sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            e.Graphics.Clear(Color.White);

            Brush FillBrush;
            Brush LineBrush;
            Brush TextBrush;

            if (Enabled)
            {
                switch (State)
                {
                    case ControlState.Normal:
                        FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Light);
                        LineBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Darker);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    case ControlState.Hover:
                        FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Dark);
                        LineBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    case ControlState.Pressed:
                        FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Medium);
                        LineBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                    default:
                        FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Light);
                        LineBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Darker);
                        TextBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        break;
                }
            }
            else
            {
                FillBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Light);
                LineBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Darker);
                TextBrush = new SolidBrush(Globals.Colors.GRAYSCALE_Dark);
            }

            e.Graphics.Clear(Color.Transparent);
            e.Graphics.FillRectangle(FillBrush, bounds);

            if (!Enabled)
            {
                int StepSize = 4;
                Pen Line = new Pen(Globals.Colors.GRAYSCALE_Medium, StepSize);

                for (int i = 0; i < this.Width + this.Height; i += (int)Math.Round(2.5 * StepSize))
                {
                    e.Graphics.DrawLine(Line, i + StepSize, 0 - StepSize, i - Height - StepSize, Height + StepSize);
                }
            }

            e.Graphics.FillRectangle(LineBrush, 0, 0, 10, Height);
            e.Graphics.DrawString(this.Text,this.Font,TextBrush, safebounds, sf);

        }
    }
}
