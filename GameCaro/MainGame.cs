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
            throw new NotImplementedException();
        }
        #region ControlsInGame
        private void ChessBoard_PlayerMark(object sender, EvenSentPoint e)
        {
            TimeDown.Value = 0;
            CountTime.Start();
            socket.Send(new SocketData((int)Socket_Commmad.SEND_POINT, e.Location, ""));
            Listen();
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
        #endregion

        #region Socket
        private void MainGame_Shown(object sender, EventArgs e)
        {
            TxB_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(TxB_IP.Text))
            {
                TxB_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            socket.IP = TxB_IP.Text;
            if (!socket.ConnectServer())
            {
                socket.CreateServer();
            }
            else
            {
                Listen();
            }
        }
        private void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    HandleData(data);
                }
                catch { }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }
        private void HandleData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)Socket_Commmad.SEND_POINT:
                    ChessBoard.PlayerMarkClick(data.Location);
                    break;
                case (int)Socket_Commmad.NEW_GAME:
                    break;
                case (int)Socket_Commmad.END_GAME:
                    break;
                case (int)Socket_Commmad.NOTIFY:
                    break;
                case (int)Socket_Commmad.QUIT:
                    break;
                case (int)Socket_Commmad.UNDO:
                    break;
            }
            Listen();
        }
        #endregion



    }
}
