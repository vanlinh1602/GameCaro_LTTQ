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
            GameManager.Socket.IP = TbIP.Text;
        }

        private void PBConnect_Click(object sender, EventArgs e)
        {
            if (!GameManager.Socket.ConnectServer())
            {
                MessageBox.Show("Không tồn tại sever.");
            }
            else
            {
                GameManager.IP = TbIP.Text;
                GameManager.CheckOpenGame = true;
                GameManager.isSever = false;
                Close();
            }
        }

        private void PBCreate_Click(object sender, EventArgs e)
        {
            GameManager.Socket.CreateServer();
            GameManager.IP = TbIP.Text;
            GameManager.isSever = true;
            GameManager.CheckOpenGame = true;
            Close();
        }
    }
}
