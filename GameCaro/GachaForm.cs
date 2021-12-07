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
        int getImage;
        event EventHandler<EventChangeChess> changeItems;
        public event EventHandler<EventChangeChess> ChangeItems
        {
            add
            {
                changeItems += value;
            }
            remove
            {
                changeItems -= value;
            }
        }
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
            return random.Next(1, 20);
        }
        private void Chest_Click(object sender, EventArgs e)
        {
            Chest.Image = Image.FromFile(Application.StartupPath + @"\Resources\OpenChest1.png");
            Character.Visible = true;
            getImage = RandomImage();
            Character.Image = Image.FromFile(Application.StartupPath + @"\Resources\Avatar\" + getImage.ToString() + @".png");
            try
            {
                GameManager.database.AddItems(GameManager.name, getImage.ToString());
            }catch { }
            Chest.Enabled = false;
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            Character.Image = null;
            Character.Visible = false;
            Chest.Image = Image.FromFile(Application.StartupPath + @"\Resources\CloseChest1.png");
            MessOpen.Visible = false;
            if (changeItems != null)
                changeItems(this, new EventChangeChess(getImage));
        }

        private void GachaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }

    public class EventChangeChess : EventArgs
    {
        int items;
        public int Items { get => items; set => items = value; }

        public EventChangeChess(int items)
        {
            this.items = items;
        }
    }
}
