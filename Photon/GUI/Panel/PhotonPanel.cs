using System;
using System.Windows.Forms;

namespace Photon.GUI
{
    public class PhotonPanel : Panel
    {
        public PhotonPanel()
        {
            Globals.Colors.OnColorsUpdated += new Action(delegate () {
                this.Invalidate();
            });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Globals.Colors.PRIMARY_Main;
            base.OnPaint(e);
            
        }
    }
}
