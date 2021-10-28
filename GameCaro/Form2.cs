using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameManager.CheckOpen = true;
            this.Close();
        }
    }
}
