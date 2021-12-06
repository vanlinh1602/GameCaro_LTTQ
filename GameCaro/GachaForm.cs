using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class GachaForm : Form
    {
        public GachaForm()
        {
            InitializeComponent();
        }

        private void OpenBTN_Click(object sender, EventArgs e)
        {
            MessOpen.Visible = true;
            Chest.Enabled = true;
        }

        int RandomImage()
        {
            Random random = new Random();
            return random.Next(1, 8);
        }
        private void Chest_Click(object sender, EventArgs e)
        {
            Chest.Image = Image.FromFile(Application.StartupPath + @"\Resources\OpenChest1.png");
            Character.Visible = true;
            int getImage = RandomImage();
            Character.Image = Image.FromFile(Application.StartupPath + @"\Resources\Avatar\" + getImage.ToString() + @".png");
            Chest.Enabled = false;
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            Character.Image = null;
            Character.Visible = false;
            Chest.Image = Image.FromFile(Application.StartupPath + @"\Resources\CloseChest1.png");
            MessOpen.Visible = false;
        }
    }
}
