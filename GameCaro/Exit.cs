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
            pictureBox2.MouseHover += MouseHover;
            pictureBox2.MouseLeave += MouseLeave;
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

        private void SurePB_Click(object sender, EventArgs e)
        {
            GameManager.checkExitGame = true;
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
