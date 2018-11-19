using Photon.Serialization;
using Photon.Serialization.Data;
using System.IO;
using System.Windows.Forms;

namespace Photon.User_Controls
{
    public partial class SpectrumPluginListItem : UserControl
    {
        public bool IsValid()
        {
            return File.Exists($@"{PluginDir}\plugin.json");
        }

        public string PluginDir;

        private string _PluginName = "Plugin name";
        public string PluginName
        {
            get
            {
                return _PluginName;
            }
            set
            {
                _PluginName = value;
                this.Plugin.Text = value;
            }
        }

        private string _AuthorName = "Author";
        public string AuthorName
        {
            get
            {
                return _AuthorName;
            }
            set
            {
                _AuthorName = value;
                this.Author.Text = $@"by {value}";
            }
        }

        private Serializer<PluginManifest> Manifest;
        
        public SpectrumPluginListItem()
        {
            InitializeComponent();
            FinalizeComponent();
        }

        public SpectrumPluginListItem(string plugin)
        {
            InitializeComponent();
            FinalizeComponent();

            this.PluginDir = plugin;
            Manifest = new Serializer<PluginManifest>(SerializerType.Json, $@"{plugin}\plugin.json", true, true);

            Plugin.Text = Manifest.Data.FriendlyName;
            Author.Text = "by " + Manifest.Data.Author;

            bool show = Manifest.Data.Author == "Mich";
            ConfigureButton.Visible = show;
            Separator_1.Visible = show;


            EnabledBox.Checked = !Manifest.Data.SkipLoad;
        }
        
        private void EnabledBox_Click(object sender, System.EventArgs e)
        {
            if (Manifest.Data != null)
            {
                Manifest.Data.SkipLoad = EnabledBox.Checked;
                Manifest.Save();
            }
        }

        private void FinalizeComponent()
        {
            this.BackColor = Globals.Colors.PRIMARY_Main;
            //this.BottomPanel.BackColor = Globals.Colors.GRAYSCALE_Light;
            this.Plugin.ForeColor = Globals.Colors.CONTROL_Lighter;
            this.Author.ForeColor = Globals.Colors.CONTROL_Lighter;
        }
    }
}
