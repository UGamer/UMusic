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
    public partial class SavePanel : Form
    {
        public SavePanel()
        {
            InitializeComponent();
        }

        public string playlistName;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            playlistName = NameBox.Text;
            this.Close();
        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                playlistName = NameBox.Text;
                this.Close();
            }
        }
    }
}