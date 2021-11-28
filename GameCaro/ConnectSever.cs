using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class ConnectSever : Form
    {
        public ConnectSever()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            TbIP.Text = SocketManager.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (String.IsNullOrEmpty(TbIP.Text))
            {
                TbIP.Text = SocketManager.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }

        }

        private void PBConnect_Click(object sender, EventArgs e)
        {
            GameManager.Socket.IP = TbIP.Text;
            if (!GameManager.Socket.ConnectServer())
            {
                MessageBox.Show("Không tồn tại sever.");
            }
            else
            {
                GameManager.CheckOpenGame = true;
                GameManager.isSever = false;
                Hide();
            }
        }

        private void PBCreate_Click(object sender, EventArgs e)
        {
            GameManager.Socket.IP = TbIP.Text;
            GameManager.Socket.CreateServer();
            GameManager.IP = TbIP.Text;
            GameManager.isSever = true;
            GameManager.CheckOpenGame = true;
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
