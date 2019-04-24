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
    }
}
