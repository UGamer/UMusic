namespace UMusic
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.FoldersTab = new System.Windows.Forms.TabPage();
            this.LocalMusicTab = new System.Windows.Forms.TabPage();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.ThemeTab = new System.Windows.Forms.TabPage();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserNameHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscordCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscordHelp = new System.Windows.Forms.Button();
            this.DownloadHelp = new System.Windows.Forms.Button();
            this.DownloadBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadBrowseButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FoldersDGV = new System.Windows.Forms.DataGridView();
            this.ThemeTypeBox = new System.Windows.Forms.ComboBox();
            this.TabControl.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.FoldersTab.SuspendLayout();
            this.ThemeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoldersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.UserTab);
            this.TabControl.Controls.Add(this.FoldersTab);
            this.TabControl.Controls.Add(this.LocalMusicTab);
            this.TabControl.Controls.Add(this.PlayerTab);
            this.TabControl.Controls.Add(this.ThemeTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.Controls.Add(this.DownloadBrowseButton);
            this.UserTab.Controls.Add(this.DownloadHelp);
            this.UserTab.Controls.Add(this.DownloadBox);
            this.UserTab.Controls.Add(this.label3);
            this.UserTab.Controls.Add(this.DiscordHelp);
            this.UserTab.Controls.Add(this.DiscordCheckBox);
            this.UserTab.Controls.Add(this.label2);
            this.UserTab.Controls.Add(this.UserNameHelp);
            this.UserTab.Controls.Add(this.UserNameBox);
            this.UserTab.Controls.Add(this.label1);
            this.UserTab.Location = new System.Drawing.Point(4, 29);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(792, 417);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User";
            this.UserTab.UseVisualStyleBackColor = true;
            // 
            // FoldersTab
            // 
            this.FoldersTab.Controls.Add(this.FoldersDGV);
            this.FoldersTab.Location = new System.Drawing.Point(4, 29);
            this.FoldersTab.Name = "FoldersTab";
            this.FoldersTab.Padding = new System.Windows.Forms.Padding(3);
            this.FoldersTab.Size = new System.Drawing.Size(792, 417);
            this.FoldersTab.TabIndex = 1;
            this.FoldersTab.Text = "Folders";
            this.FoldersTab.UseVisualStyleBackColor = true;
            // 
            // LocalMusicTab
            // 
            this.LocalMusicTab.Location = new System.Drawing.Point(4, 29);
            this.LocalMusicTab.Name = "LocalMusicTab";
            this.LocalMusicTab.Padding = new System.Windows.Forms.Padding(3);
            this.LocalMusicTab.Size = new System.Drawing.Size(792, 417);
            this.LocalMusicTab.TabIndex = 2;
            this.LocalMusicTab.Text = "Local Music";
            this.LocalMusicTab.UseVisualStyleBackColor = true;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Location = new System.Drawing.Point(4, 29);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerTab.Size = new System.Drawing.Size(792, 417);
            this.PlayerTab.TabIndex = 3;
            this.PlayerTab.Text = "Player";
            this.PlayerTab.UseVisualStyleBackColor = true;
            // 
            // ThemeTab
            // 
            this.ThemeTab.Controls.Add(this.ThemeTypeBox);
            this.ThemeTab.Controls.Add(this.TextColorButton);
            this.ThemeTab.Location = new System.Drawing.Point(4, 29);
            this.ThemeTab.Name = "ThemeTab";
            this.ThemeTab.Padding = new System.Windows.Forms.Padding(3);
            this.ThemeTab.Size = new System.Drawing.Size(792, 417);
            this.ThemeTab.TabIndex = 4;
            this.ThemeTab.Text = "Theme";
            this.ThemeTab.UseVisualStyleBackColor = true;
            // 
            // ColorPicker
            // 
            this.ColorPicker.FullOpen = true;
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new System.Drawing.Point(38, 73);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(122, 47);
            this.TextColorButton.TabIndex = 0;
            this.TextColorButton.Text = "Text Color";
            this.TextColorButton.UseVisualStyleBackColor = true;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(229, 20);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(332, 26);
            this.UserNameBox.TabIndex = 1;
            // 
            // UserNameHelp
            // 
            this.UserNameHelp.Location = new System.Drawing.Point(6, 20);
            this.UserNameHelp.Name = "UserNameHelp";
            this.UserNameHelp.Size = new System.Drawing.Size(37, 26);
            this.UserNameHelp.TabIndex = 2;
            this.UserNameHelp.Text = "?";
            this.UserNameHelp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discord Rich Presence:";
            // 
            // DiscordCheckBox
            // 
            this.DiscordCheckBox.AutoSize = true;
            this.DiscordCheckBox.Location = new System.Drawing.Point(229, 59);
            this.DiscordCheckBox.Name = "DiscordCheckBox";
            this.DiscordCheckBox.Size = new System.Drawing.Size(22, 21);
            this.DiscordCheckBox.TabIndex = 4;
            this.DiscordCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscordHelp
            // 
            this.DiscordHelp.Location = new System.Drawing.Point(6, 56);
            this.DiscordHelp.Name = "DiscordHelp";
            this.DiscordHelp.Size = new System.Drawing.Size(37, 26);
            this.DiscordHelp.TabIndex = 5;
            this.DiscordHelp.Text = "?";
            this.DiscordHelp.UseVisualStyleBackColor = true;
            // 
            // DownloadHelp
            // 
            this.DownloadHelp.Location = new System.Drawing.Point(6, 97);
            this.DownloadHelp.Name = "DownloadHelp";
            this.DownloadHelp.Size = new System.Drawing.Size(37, 26);
            this.DownloadHelp.TabIndex = 8;
            this.DownloadHelp.Text = "?";
            this.DownloadHelp.UseVisualStyleBackColor = true;
            // 
            // DownloadBox
            // 
            this.DownloadBox.Location = new System.Drawing.Point(229, 97);
            this.DownloadBox.Name = "DownloadBox";
            this.DownloadBox.ReadOnly = true;
            this.DownloadBox.Size = new System.Drawing.Size(275, 26);
            this.DownloadBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Download Path:";
            // 
            // DownloadBrowseButton
            // 
            this.DownloadBrowseButton.Location = new System.Drawing.Point(499, 97);
            this.DownloadBrowseButton.Name = "DownloadBrowseButton";
            this.DownloadBrowseButton.Size = new System.Drawing.Size(61, 26);
            this.DownloadBrowseButton.TabIndex = 9;
            this.DownloadBrowseButton.Text = "...";
            this.DownloadBrowseButton.UseVisualStyleBackColor = true;
            this.DownloadBrowseButton.Click += new System.EventHandler(this.DownloadBrowseButton_Click);
            // 
            // FoldersDGV
            // 
            this.FoldersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoldersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldersDGV.Location = new System.Drawing.Point(3, 3);
            this.FoldersDGV.Name = "FoldersDGV";
            this.FoldersDGV.RowTemplate.Height = 28;
            this.FoldersDGV.Size = new System.Drawing.Size(786, 411);
            this.FoldersDGV.TabIndex = 0;
            // 
            // ThemeTypeBox
            // 
            this.ThemeTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeTypeBox.FormattingEnabled = true;
            this.ThemeTypeBox.Items.AddRange(new object[] {
            "Color",
            "Custom"});
            this.ThemeTypeBox.Location = new System.Drawing.Point(38, 28);
            this.ThemeTypeBox.Name = "ThemeTypeBox";
            this.ThemeTypeBox.Size = new System.Drawing.Size(277, 28);
            this.ThemeTypeBox.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            this.FoldersTab.ResumeLayout(false);
            this.ThemeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoldersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage FoldersTab;
        private System.Windows.Forms.TabPage LocalMusicTab;
        private System.Windows.Forms.TabPage PlayerTab;
        private System.Windows.Forms.TabPage ThemeTab;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button TextColorButton;
        private System.Windows.Forms.Button UserNameHelp;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DiscordCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DiscordHelp;
        private System.Windows.Forms.Button DownloadHelp;
        private System.Windows.Forms.TextBox DownloadBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.DataGridView FoldersDGV;
        private System.Windows.Forms.ComboBox ThemeTypeBox;
    }
}