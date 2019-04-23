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
    public partial class PictureEditor : Form
    {
        bool mouseClicked = false;

        public PictureEditor(Image currentPicture)
        {
            InitializeComponent();
            ChangePicture(currentPicture);
        }

        public void ChangePicture(Image currentPicture)
        {
            PictureBox.BackgroundImage = currentPicture;
        }

        private void CropBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void CropBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void CropBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.CropBox.Width = CropBox.Left + e.X;
                this.CropBox.Height = CropBox.Width;
            }
        }
    }
}
