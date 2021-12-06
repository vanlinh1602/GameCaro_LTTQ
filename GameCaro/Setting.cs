using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Setting : Form
    {
        public bool CheckSurrender = false;
        HistoryGacha history;
        public Setting()
        {
            InitializeComponent();
        }

        private void PbSurrender_Click(object sender, EventArgs e)
        {
            CheckSurrender = true;
            Close();
        }

        private void PbQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        private void DownVolume_Click(object sender, EventArgs e)
        {
            GameManager.media.VolumeDown();
        }

        private void UpVolume_Click(object sender, EventArgs e)
        {
            GameManager.media.VolumeUp();

        }

        private void MusicBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() 
            {
                FileName = "Select a MP3 file",
                Filter = "MP3 files (*.mp3)|*.mp3",
            };
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                GameManager.media.url = openFile.FileName;
                GameManager.media.Start();
            }    
        }

        private void HistoryBTN_Click(object sender, EventArgs e)
        {
            history = new HistoryGacha();
            history.ShowDialog();
        }
    }
}
