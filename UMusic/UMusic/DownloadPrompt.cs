using System;
using System.Windows.Forms;

namespace UMusic
{
    public partial class DownloadPrompt : Form
    {
        public DownloadPrompt()
        {
            InitializeComponent();
        }

        public bool exist = true;
        public bool audio;
        public bool video;

        private void AudioButton_Click(object sender, EventArgs e)
        {
            audio = true;
            exist = false;
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            video = true;
            exist = false;
        }

        private void BothButton_Click(object sender, EventArgs e)
        {
            audio = true;
            video = true;
            exist = false;
        }

        private void NeitherButton_Click(object sender, EventArgs e)
        {
            exist = false;
        }
    }
}
