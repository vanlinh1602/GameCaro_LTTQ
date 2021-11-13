using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
            SurePB.MouseHover += MouseHover;
            SurePB.MouseLeave += MouseLeave;
            CancelPB.MouseHover += MouseHover;
            CancelPB.MouseLeave += MouseLeave;
        }

        void MouseHover(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.BackgroundImageLayout = ImageLayout.Zoom;
        }
        void MouseLeave(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void CancelPB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SurePB_Click(object sender, EventArgs e)
        {
            GameManager.checkExitGame = true;
            Close();
        }
    }
}
