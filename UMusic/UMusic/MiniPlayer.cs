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
using Utilities;

namespace UMusic
{
    public partial class MiniPlayer : Form
    {
        Player reference;
        Timer leavingTimer;
        globalKeyboardHook gkh;

        globalKeyboardHook shiftGKH = new globalKeyboardHook();
        bool shiftDown = false;
        bool hidden = false;

        public MiniPlayer(Player reference)
        {
            this.reference = reference;
            InitializeComponent();

            if (reference.playing == true)
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Pause.png");
            else
                PlayPauseButton.BackgroundImage = Image.FromFile("Resources\\Play.png");

            LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");

            DisplayInfo();

            gkh = new globalKeyboardHook();

            shiftGKH.HookedKeys.Add(Keys.LShiftKey);
            shiftGKH.KeyDown += new KeyEventHandler(shiftGKH_KeyDown);
            shiftGKH.KeyUp += new KeyEventHandler(shiftGKH_KeyUp);

            gkh.HookedKeys.Add(Keys.Tab);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (shiftDown == true)
            {
                if (this.TopMost == false)
                {
                    if (hidden == false)
                    {
                        this.Hide();
                        hidden = true;
                    }
                    else
                    {
                        this.Show();
                        hidden = false;
                    }
                }
            }
        }

        public void DisplayInfo()
        {
            this.BackgroundImage = reference.AlbumArtBox.BackgroundImage;
            TopText.Text = reference.currentFile.Tag.Title;
            ArtistBox.Text = reference.currentFile.Tag.FirstPerformer;
        }

        private void MiniPlayer_MouseEnter(object sender, EventArgs e)
        {
            TopText.Visible = true;

            if (ArtistBox.Text != "")
                ArtistBox.Visible = true;
            
            ControlsPanel.Visible = true;
        }

        private void MiniPlayer_MouseLeave(object sender, EventArgs e)
        {
            leavingTimer = new Timer();
            leavingTimer.Interval = 3000;
            leavingTimer.Tick += leavingTimer_Tick;
            leavingTimer.Start();
        }

        private void leavingTimer_Tick(object sender, EventArgs e)
        {
            TopText.Visible = false;
            ArtistBox.Visible = false;
            ControlsPanel.Visible = false;

            leavingTimer.Stop();
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            reference.PlayPause();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {

        }
        
        private void shiftGKH_KeyDown(object sender, KeyEventArgs e)
        {
            shiftDown = true;
        }

        private void shiftGKH_KeyUp(object sender, KeyEventArgs e)
        {
            shiftDown = false;
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                LockButton.BackgroundImage = Image.FromFile("Resources\\Lock.png");
                this.TopMost = true;
            }
            else
            {
                LockButton.BackgroundImage = Image.FromFile("Resources\\Unlock.png");
                this.TopMost = false;
            }
        }
    }
}
