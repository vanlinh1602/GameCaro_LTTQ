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
        void AddPlayerToDatabase()
        {
            try
            {
                GameManager.database.AddPlayer(TbName.Text);
            }
            catch { }
        }
        private void PBConnect_Click(object sender, EventArgs e)
        {
            if (!CheckName())
                return;
            GameManager.name = TbName.Text;
            GameManager.Socket.IP = TbIP.Text;
            AddPlayerToDatabase();
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
            if (!CheckName())
                return;
            GameManager.name = TbName.Text;
            GameManager.Socket.IP = TbIP.Text;
            try
            {
                GameManager.Socket.CreateServer();
            }
            catch 
            {
                MessageBox.Show("Đã tồn tại server");
                return;
            }
            GameManager.IP = TbIP.Text;
            GameManager.isSever = true;
            GameManager.CheckOpenGame = true;
            AddPlayerToDatabase();
            Hide();

        }
        bool CheckName()
        {
            if (string.IsNullOrEmpty(TbName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên");
                return false;
            }
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
