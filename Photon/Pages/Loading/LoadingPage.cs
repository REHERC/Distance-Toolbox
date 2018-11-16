namespace Photon.Pages.Loading
{
    public partial class LoadingPage : Photon.GUI.ToolPage.ToolPage
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void ManagerSettingsCreatePage_Load(object sender, System.EventArgs e)
        {
            EmptyContainer.BackColor = Globals.Colors.GRAYSCALE_Light;
        }
    }
}
