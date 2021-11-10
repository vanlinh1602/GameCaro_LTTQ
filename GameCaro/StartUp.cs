using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class StartUp : Form
    {
        ConnectSever connect;
        public StartUp()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            connect = new ConnectSever();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            connect.ShowDialog();
            if(!String.IsNullOrEmpty(GameManager.IP))
                Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
