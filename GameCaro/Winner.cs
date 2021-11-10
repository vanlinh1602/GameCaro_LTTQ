using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        private void okPBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okPBox_MouseHover(object sender, EventArgs e)
        {
            okPBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void okPBox_MouseLeave(object sender, EventArgs e)
        {
            okPBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
