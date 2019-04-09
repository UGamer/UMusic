using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMusic
{
    public partial class MiniPlayer : Form
    {
        public MiniPlayer()
        {
            InitializeComponent();

            var file = TagLib.File.Create("drip.mp3");
            if (file.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                this.BackgroundImage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(500, 500, null, IntPtr.Zero);
            }

            TopText.Text = file.Tag.Title;
        }

        private void MiniPlayer_MouseEnter(object sender, EventArgs e)
        {
            TopText.Visible = true;
        }

        private void MiniPlayer_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
