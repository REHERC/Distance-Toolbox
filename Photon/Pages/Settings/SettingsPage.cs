using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Photon.Serialization.Data;

namespace Photon.Pages.Settings
{
    public partial class SettingsPage : Photon.GUI.ToolPage.ToolPage
    {
        private AppSettings GeneralSettings;
        
        public SettingsPage()
        {
            InitializeComponent();
            GeneralSettings = Globals.Settings.General.Data;
            GameDirBox.Text = GeneralSettings.GameDir;
        }

        private void SettingsPage_Load(object sender, System.EventArgs e)
        {
            BottomPanel.BackColor = Globals.Colors.CONTROL_Dark;
            BottomSeparator.BackColor = Globals.Colors.PRIMARY_Main;
            InterfaceColorPick.BackColor = Globals.Colors.PRIMARY_Main;
        }
        
        private void GamePathBtn_Click(object sender, System.EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog Dialog = new Microsoft.Win32.OpenFileDialog
            {
                FileName = "Distance.exe", // Default file name
                DefaultExt = ".exe", // Default file extension
                Filter = "Distance.exe|Distance.exe" // Filter files by extension
            };
            if (Dialog.ShowDialog() == true)
            {
                string file = Dialog.FileName;
                string path = file.Substring(0, file.Length - new List<string>(file.Split('\\')).Last().Length);
                
                GameDirBox.Text = path;
                GeneralSettings.GameDir = path;
            }
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Ok_Click(object sender, System.EventArgs e)
        {
            Apply();
            Close();
        }

        private void Apply()
        {
            Globals.Settings.General.Data = GeneralSettings;
            Globals.Settings.General.Save();
            
            Globals.Colors.PRIMARY_Main = ColorExtensions.Deserialize(GeneralSettings.AppColor);
            Globals.Colors.UpdateColors();
        }

        private void Close() {
            Globals.Settings.General.Load();
            Globals.Variables.MainForm.SetPage("pages:home");
        }

        private void InterfaceColorPick_Click(object sender, System.EventArgs e)
        {
            ColorDialog Colorpicker = new ColorDialog
            {
                Color = Globals.Colors.PRIMARY_Main,
                AnyColor = true,
                AllowFullOpen = true
            };

            if (Colorpicker.ShowDialog() == DialogResult.OK)
            {
                InterfaceColorPick.BackColor = Colorpicker.Color;
                GeneralSettings.AppColor = Colorpicker.Color.Serialize();
            }

            Colorpicker.Dispose();
        }

        private void Apply_Click(object sender, System.EventArgs e)
        {
            Apply();
        }

        private void OptionsTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
