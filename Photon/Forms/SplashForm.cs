using System;
using System.Windows.Forms;

namespace Photon.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            MainPanel.BackColor = Globals.Colors.BACKGROUND_Dark;
            HeaderParent.BackColor = Globals.Colors.PRIMARY_Main;
            AppName.ForeColor = Globals.Colors.TEXT_Light;
            LoadingLabel.ForeColor = Globals.Colors.TEXT_Light;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
