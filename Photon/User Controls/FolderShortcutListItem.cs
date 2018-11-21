using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Photon.User_Controls
{
    public partial class FolderShortcutListItem : UserControl
    {
        private string _Title = "Title";
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                TitleBox.Text = value;
            }
        }

        private string _Description = "Description";
        [Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                DescriptionBox.Text = value;
            }
        }

        private string Path = "";

        public FolderShortcutListItem()
        {
            InitializeComponent();
            LeaveButton();
            OpenBtn.Enabled = false;
        }

        public FolderShortcutListItem(string path, string title, string description)
        {
            InitializeComponent();
            LeaveButton();
            TitleBox.Text = title;
            DescriptionBox.Text = description;
            
            Path = path;

            
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path))
            {
                Process.Start(Path);
            }
            else
            {
                MessageBox.Show("The directory you're looking for doesn't exist.");
            }
            
        }

        private void OpenBtn_MouseEnter(object sender, EventArgs e)
        {
            EnterButton();
        }

        private void OpenBtn_MouseLeave(object sender, EventArgs e)
        {
            LeaveButton();
        }

        void EnterButton()
        {
            LeftLine.BackColor = Globals.Colors.GRAYSCALE_Dark;
            RightLine.BackColor = Globals.Colors.GRAYSCALE_Dark;
        }

        void LeaveButton()
        {
            LeftLine.BackColor = Globals.Colors.GRAYSCALE_Light;
            RightLine.BackColor = Globals.Colors.GRAYSCALE_Light;
        }
    }
}
