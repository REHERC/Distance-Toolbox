using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photon.GUI
{
    public class PhotonCheckButton : Control
    {
        public PhotonCheckButton()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });
        }

        private bool _Checked = false;
        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                _Checked = value;
                Invalidate();
            }
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
                Checked = !Checked;
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
            int bordersize = 4;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            
            int barwidth = (Width - (4 * bordersize)) / 2;
            Rectangle checkfill;

            if (Checked)
            {
                this.Text = "On";
                checkfill = new Rectangle(
                    (2 * bordersize) + barwidth,
                    2 * bordersize,
                    barwidth,
                    Height - (4 * bordersize)
                );
            }
            else
            {
                this.Text = "Off";
                checkfill = new Rectangle(
                    (2 * bordersize),
                    2 * bordersize,
                    barwidth,
                    Height - (4 * bordersize)
                );
            }
            
            Brush FillBrush;
            Brush LineBrush;
            Brush CheckBrush = Enabled ? (Checked ? new SolidBrush(Globals.Colors.GRAYSCALE_Light) : new SolidBrush(Globals.Colors.GRAYSCALE_Light)) : new SolidBrush(Globals.Colors.GRAYSCALE_Darker);
            
            if (Enabled)
            {
                switch (State)
                {
                    case ControlState.Normal:
                        FillBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        LineBrush = new SolidBrush(Globals.Colors.CONTROL_Light);
                        break;
                    case ControlState.Hover:
                        FillBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        LineBrush = new SolidBrush(Globals.Colors.CONTROL_Light);
                        break;
                    case ControlState.Pressed:
                        FillBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        LineBrush = new SolidBrush(Globals.Colors.CONTROL_Light);
                        break;
                    default:
                        FillBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                        LineBrush = new SolidBrush(Globals.Colors.CONTROL_Light);
                        break;
                }
            }
            else
            {
                FillBrush = new SolidBrush(Globals.Colors.PRIMARY_Main);
                LineBrush = new SolidBrush(Globals.Colors.CONTROL_Light);
            }

            e.Graphics.Clear(BackColor);

            e.Graphics.FillRectangle(LineBrush, bounds);
            e.Graphics.FillRectangle(FillBrush, bounds.Padding(bordersize, bordersize, -bordersize, -bordersize));

            e.Graphics.FillRectangle(CheckBrush, checkfill);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Font font = new Font(this.Font, FontStyle.Bold);
            
            e.Graphics.DrawString(this.Text, font, FillBrush, checkfill, sf);
        }
    }
}
