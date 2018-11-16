using System.Drawing;
using System.Windows.Forms;
using Photon.User_Controls;

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
            LoadPluginList();
        }

        private void Close()
        {
            Globals.Variables.MainForm.SetPage("pages:home");
        }

        private void ManagePluginsMainPage_Load(object sender, System.EventArgs e)
        {
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;

            NoPluginsLabel.ForeColor = Globals.Colors.CONTROL_Dark;
        }

        private void LoadPluginList()
        {
            PluginList.Controls.Clear();
            for (int i = 0; i < 16; i++)
            {
                SpectrumPluginListItem Item = new SpectrumPluginListItem();

                Item.PluginName = $"Plugin #{i}";
                Item.Dock = DockStyle.Top;

                PluginList.Controls.Add(Item);

                Item.BringToFront();



                Panel Separator = new Panel();
                
                Separator.Height = 8;
                Separator.Dock = DockStyle.Top;

                PluginList.Controls.Add(Separator);

                Separator.BringToFront();
            }
        }
    }
}
