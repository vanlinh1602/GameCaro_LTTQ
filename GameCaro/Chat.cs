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
        public Chat()
        {
            InitializeComponent();

        }
<<<<<<< HEAD
=======
    }
    public class EventSentMess : EventArgs
    {
        string mess;
        public string Mess { get => mess; set => mess = value; }
        public EventSentMess(string mess)
        {
            this.mess = mess;
        }
>>>>>>> linh
    }
}
