using System.Windows.Forms;

namespace Photon.GUI
{
    class PhotonTextBox : TextBox
    {
        public PhotonTextBox()
        {
            BorderStyle = BorderStyle.None;
            BackColor = Globals.Colors.TEXT_Light;
            ForeColor = Globals.Colors.PRIMARY_Main;
        }

    }
}
