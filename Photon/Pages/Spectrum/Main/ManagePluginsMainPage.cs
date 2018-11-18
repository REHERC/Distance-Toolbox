using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Photon.User_Controls;

namespace Photon.Pages.Spectrum
{
    public partial class ManagePluginsMainPage : Photon.GUI.ToolPage.ToolPage
    {
        public ManagePluginsMainPage()
        {
            InitializeComponent();
            LoadPluginList();
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        
        private void Ok_Click(object sender, System.EventArgs e)
        {
            LoadPluginList();
        }

        private void Close()
        {
            Globals.Variables.MainForm.SetPage("pages:home");
        }

        public override void Reload()
        {
            base.Reload();
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;

            NoPluginsLabel.ForeColor = Globals.Colors.CONTROL_Dark;
        }

        private void ManagePluginsMainPage_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void LoadPluginList()
        {
            NoPluginsPanel.Visible = true;
            PluginList.Controls.Clear();

            string pluginsdir = $@"{Globals.Settings.General.Data.GameDir}\Distance_Data\Spectrum\Plugins";
            
            if (!Directory.Exists(pluginsdir))
            {
                return;
            }

            foreach (string plugin in Directory.GetDirectories(pluginsdir)) {
                SpectrumPluginListItem Item = new SpectrumPluginListItem(plugin)
                {
                    Dock = DockStyle.Top
                };

                if (!Item.IsValid())
                {
                    continue;
                }

                NoPluginsPanel.Visible = false;
                
                PluginList.Controls.Add(Item);
                Item.BringToFront();
                
                Panel Separator = new Panel
                {
                    Height = 8,
                    Dock = DockStyle.Top
                };
                PluginList.Controls.Add(Separator);
                Separator.BringToFront();
            }
        }
    }
}
