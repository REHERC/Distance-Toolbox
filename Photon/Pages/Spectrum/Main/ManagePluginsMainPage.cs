namespace Photon.Pages.Spectrum
{
    public partial class ManagePluginsMainPage : Photon.GUI.ToolPage.ToolPage
    {
        public ManagePluginsMainPage()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        
        private void Ok_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Close()
        {
            Globals.Variables.MainForm.SetPage("pages:home");
        }

        private void ManagePluginsMainPage_Load(object sender, System.EventArgs e)
        {
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
        }
    }
}
