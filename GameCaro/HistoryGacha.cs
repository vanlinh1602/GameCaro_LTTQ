using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{

    public partial class HistoryGacha : Form
    {
        DatabaseManager database = new DatabaseManager();
        public HistoryGacha()
        {
            InitializeComponent();
            HitoryGacha.BackgroundColor = Color.FromArgb(79, 84, 75);
        }

        private void HistoryGacha_Load(object sender, EventArgs e)
        {
            TbName.Text = GameManager.name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                HitoryGacha.DataSource = database.GetData(TbName.Text);
            }
            catch { }
        }
    }
}
