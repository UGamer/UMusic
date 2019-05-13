using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMusic
{
    public partial class Settings : Form
    {
        Form1 reference;
        public bool changed = false;

        public Settings(Form1 reference)
        {
            this.reference = reference;
            InitializeComponent();

            UserNameBox.TextChanged += MarkAsChanged;
            DiscordCheckBox.CheckedChanged += MarkAsChanged;

            InitializeTooltips();
            InitializeTheme();
            InitializeSettings();
        }

        private void InitializeTheme()
        {
            
        }

        private void InitializeTooltips()
        {
            ToolTip[] toolTips = new ToolTip[18];
            string[] tips = new string[18];

            for (int index = 0; index < 18; index++)
            {
                toolTips[index] = new ToolTip();
            }

            toolTips[0].SetToolTip(UserNameHelp, "This currently has no use. In the future, UMusic will " +
                "refer to you by this name.");
            toolTips[1].SetToolTip(DiscordHelp, "Displays your Discord status as \"Playing UMusic\" and displays " +
                "what song you're listening to, who's it by, and how much left of the song there is.");
            toolTips[2].SetToolTip(DownloadHelp, "Determine where downloaded songs are stored on your computer.");
        }

        private void InitializeSettings()
        {
            string settings = reference.settings;
            UserNameBox.Text = settings.Substring(settings.IndexOf("Name=") + 6);
            UserNameBox.Text = UserNameBox.Text.Substring(0, UserNameBox.Text.IndexOf("\""));

            if (settings.IndexOf("DiscordRichPresence=\"Enabled\"") != -1)
                DiscordCheckBox.Checked = true;

            DownloadBox.Text = settings.Substring(settings.IndexOf("DownloadLocation=") + 18);
            DownloadBox.Text = DownloadBox.Text.Substring(0, DownloadBox.Text.IndexOf("\""));

            DataTable foldersData = new DataTable();
            foldersData.Columns.Add();
            for (int index = 0; index < reference.folders.Length; index++)
            {
                DataRow newRow = foldersData.NewRow();
                newRow[0] = reference.folders[index];
                foldersData.Rows.Add(newRow);
            }
            FoldersDGV.DataSource = foldersData;

            string themeType = settings.Substring(settings.IndexOf("Type=") + 5);
            ThemeTypeBox.Text = themeType.Substring(0, themeType.IndexOf("\n"));
            
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                TextColorButton.ForeColor = ColorPicker.Color;
                changed = true;
            }
        }

        private void DownloadBrowseButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                DownloadBox.Text = FolderBrowser.SelectedPath + "\\";
                changed = true;
            }
        }

        private void MarkAsChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed == true)
            {
                string newSettings = "User\nName=\"" + UserNameBox.Text + "\"\n";

                newSettings += "DiscordRichPresence=\"" + 
                    DiscordCheckBox.Checked.ToString() + "\"\n";

                newSettings += "DownloadLocation=\"" + DownloadBox.Text + "\"\n\n";

                this.Close();
            }
        }
    }
}
