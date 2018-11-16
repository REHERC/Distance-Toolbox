using System;
using System.Threading.Tasks;
using Photon.Pages.Home;
using Photon.Serialization;
using Photon.Serialization.Data;

namespace Photon.Pages.Spectrum
{
    public partial class ManagerSettingsCreatePage : Photon.Pages.Loading.LoadingPage
    {
        public Serializer<ManagerSettings> ManagerSettings;

        public ManagerSettingsCreatePage()
        {
            InitializeComponent();
        }

        private void ManagerSettingsCreatePage_Load(object sender, EventArgs e)
        {
            Tools.Wait(0.01,delegate() {
                string GamePath = Globals.Settings.General.Data.GameDir;

                ManagerSettings = new Serializer<ManagerSettings>(SerializerType.Json, $@"{GamePath}\Distance_Data\Spectrum\Settings\ManagerSettings.json", false, true);
                ManagerSettings.Save();

                MessageLabel.Text = "File created !";

                Tools.Wait(0.1, delegate () {
                    HomePage Home = Globals.Variables.MainForm.GetPage("pages:home") as HomePage;
                    Home.SpectrumPluginsBtn_Click(null, null);
                    Globals.Variables.MainForm.RemovePage(this.PageName);
                });
            });
        }
    }
}
