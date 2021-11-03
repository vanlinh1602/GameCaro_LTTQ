using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class MainGame : Form
    {
        ChessBoardManager ChessBoard;
        SocketManager socket;
        public MainGame()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            ChessBoard = new ChessBoardManager(Chess_Board);
            SetUpTimeDown();
            ChessBoard.EndGame += ChessBoard_EndGame;
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
            socket = new SocketManager();
            NewGame();
        }
        private void ChessBoard_PlayerMark(object sender, EventArgs e)
        {
            TimeDown.Value = 0;
            CountTime.Start();
        }
        private void ChessBoard_EndGame(object sender, EventArgs e)
        {
            EndGame();
        }
        void SetUpTimeDown()
        {
            TimeDown.Step = GameManager.Process_Step;
            TimeDown.Maximum = GameManager.Process_Maximun;
            CountTime.Interval = GameManager.Timer_Interval;
        }
        private void CountTime_Tick(object sender, EventArgs e)
        {
            TimeDown.PerformStep();
            if (TimeDown.Value >= GameManager.Process_Maximun)
            {
                EndGame();
            }
        }
        void Quit()
        {
            Application.Exit();
        }
        void NewGame()
        {
            CountTime.Stop();
            TimeDown.Value = 0;
            ChessBoard.DrawChessBoard();
        }
        private void EndGame()
        {
            CountTime.Stop();
            MessageBox.Show("End Game! Good job Bro");
            Chess_Board.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.Undo();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Warring", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void MainGame_Shown(object sender, EventArgs e)
        {
            TxB_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (TxB_IP.Text == "")
            {
                TxB_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socket.IP = TxB_IP.Text;
            if (!socket.ConnectSever())
            {
                socket.ConnectSever();
                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            else
            {
                Thread listenThread = new Thread(() =>
                {
                    Listen();
                });
                listenThread.IsBackground = true;
                listenThread.Start();
                socket.Send("Đây là thông tin từ client");
            }
        }
        private void Listen()
        {
            string data = (string)socket.Receive();
            MessageBox.Show(data);
        }
    }
}
