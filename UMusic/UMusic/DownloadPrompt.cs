using System;
using System.IO;
using System.Windows.Forms;

namespace UMusic
{
    public partial class DownloadPrompt : Form
    {
        Form1 main;
        string fileName;

        public DownloadPrompt(Form1 main, string fileName, string videoName)
        {
            this.main = main;
            this.fileName = fileName;
            InitializeComponent();
            VideoNameBox.Text = videoName;
        }
        
        public bool audio;
        public bool video;

        private void AudioButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(main.downloadLocation + fileName + ".mp4"))
                File.Delete(main.downloadLocation + fileName + ".mp4");

            this.Close();
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(main.downloadLocation + fileName + ".mp3"))
                File.Delete(main.downloadLocation + fileName + ".mp3");

            this.Close();
        }

        private void BothButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NeitherButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(main.downloadLocation + fileName + ".mp3"))
                File.Delete(main.downloadLocation + fileName + ".mp3");

            if (File.Exists(main.downloadLocation + fileName + ".mp4"))
                File.Delete(main.downloadLocation + fileName + ".mp4");

            this.Close();
        }   
    }
}
