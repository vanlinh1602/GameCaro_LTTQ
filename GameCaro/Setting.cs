using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Setting : Form
    {
        public bool CheckSurrender = false;
        public Setting()
        {
            InitializeComponent();
        }

        private void PbSurrender_Click(object sender, EventArgs e)
        {
            CheckSurrender = true;
            Close();
        }

        private void PbQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
