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
    public partial class Playlist : Form
    {
        Player reference;
        WMPLib.IWMPMedia[] items;

        public Playlist(Player reference)
        {
            this.reference = reference;
            InitializeComponent();

            LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");

            FillList();
        }

        private void FillList()
        {
            items = new WMPLib.IWMPMedia[reference.playlist.count];

            for (int index = 0; index < items.Length; index++)
                items[index] = reference.playlist.Item[index];
            
            PlaylistItemDGV.DataSource = items;
        }
    }
}
