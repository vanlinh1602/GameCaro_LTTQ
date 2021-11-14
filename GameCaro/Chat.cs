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
        #region Control

        
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
            for (int i = 0; i < fileLines.Length; i++)
            {

                kaomojiList.Items.Add(new ListViewItem(fileLines[i]));

            }
        }
        private void kaomojiList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView icon = sender as ListView;
            chatTextBox.Text += icon.FocusedItem.Text;
        }

        #endregion
        #region Socket
        private void sendPBox_Click(object sender, EventArgs e)
        {
            chatDisplay.Text += "You: " + chatTextBox.Text + "\n";
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.CHAT, new Point(), chatTextBox.Text));
            chatTextBox.Clear();
        }

        #endregion

        private void chatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                sendPBox_Click(null, null);
            }
        }

        private void tempSendPBox_MouseHover(object sender, EventArgs e)
        {
            tempSendPBox.Hide();
        }

        private void sendPBox_MouseLeave(object sender, EventArgs e)
        {
            tempSendPBox.Show();
        }
    }
}
