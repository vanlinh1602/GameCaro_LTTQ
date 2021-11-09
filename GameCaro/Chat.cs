using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Chat : Form
    {
        event EventHandler<EventSentMess> sendMessage;
        public event EventHandler<EventSentMess> SendMessage
        {
            add
            {
                sendMessage += value;
            }
            remove
            {
                sendMessage -= value;
            }
        }
        public Chat()
        {
            InitializeComponent();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sendMessage != null)
                this.sendMessage(this, new EventSentMess(tbMess.Text));
            richTextBox1.Text += "You: " + tbMess.Text + "\n";
            tbMess.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGame.checkShown = false;
        }
        private void tbMess_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnSend_Click(null, null);
            }
        }
    }
    public class EventSentMess : EventArgs
    {
        string mess;
        public string Mess { get => mess; set => mess = value; }
        public EventSentMess(string mess)
        {
            this.mess = mess;
        }
    }
}
