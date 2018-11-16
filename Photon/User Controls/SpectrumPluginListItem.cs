using System.Windows.Forms;

namespace Photon.User_Controls
{
    public partial class SpectrumPluginListItem : UserControl
    {
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

        public SpectrumPluginListItem()
        {
            InitializeComponent();
            this.BackColor = Globals.Colors.PRIMARY_Main;
            //this.BottomPanel.BackColor = Globals.Colors.GRAYSCALE_Light;
            this.Plugin.ForeColor = Globals.Colors.CONTROL_Lighter;
            this.Author.ForeColor = Globals.Colors.CONTROL_Lighter;
        }
    }
}
