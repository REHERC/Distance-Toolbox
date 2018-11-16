using System;
using System.Windows.Forms;

namespace Photon.GUI
{
    public class PhotonLabel : Label
    {
        public PhotonLabel()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ForeColor = Globals.Colors.CONTROL_Lighter;
            base.OnPaint(e);
        }
    }
}
