using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Chat : Form
    {
        public Chat()
        {
            
            InitializeComponent();

        }

        private void sendPBox_Click(object sender, EventArgs e)
        {

        }

        private void sendPBox_MouseHover(object sender, EventArgs e)
        {
            sendPBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void sendPBox_MouseLeave(object sender, EventArgs e)
        {
            sendPBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void kaomojiPBox_Click(object sender, EventArgs e)
        {
            if (!kaomojiList.Visible)
                kaomojiList.Show();
            else
                kaomojiList.Hide();
        }

        private void kaomojiPBox_MouseHover(object sender, EventArgs e)
        {
            kaomojiPBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void kaomojiPBox_MouseMove(object sender, MouseEventArgs e)
        {
            kaomojiPBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            String[] fileLines = File.ReadAllLines(Application.StartupPath + "\\Kaomoji.txt");
            for(int i = 0; i < fileLines.Length; i++)
            {

                kaomojiList.Items.Add(new ListViewItem(fileLines[i]));
                
            }
        }
    }
}
