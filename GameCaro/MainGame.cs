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
        Chat formChat;
        bool isMoreNewGame = false;
        public MainGame()
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            ChessBoard = new ChessBoardManager(Chess_Board);
            formChat = new Chat();
            ChessBoard.EndGame += ChessBoard_EndGame;
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
<<<<<<< HEAD
            ChessBoard.GetPointForWiner += ChessBoard_GetPointForWiner;
            formChat.SendMessage += FormChat_SendMessage;
=======
>>>>>>> origin/khanh
            NewGame();
            ChangeAvatar(true, 1);
            ChangeAvatar(false, 2);
            isMoreNewGame = true;
            if (!GameManager.isSever)
            {
                Chess_Board.Enabled = false;
                Listen();
            }
        }

        private void ChessBoard_GetPointForWiner(object sender, EventPointWiner e)
        {
            if(e.Winer == 1)
            {
                PointLayer1.Text = (int.Parse(PointLayer1.Text) + 1).ToString();
            }
            else
            {
                PointLayer2.Text = (int.Parse(PointLayer2.Text) + 1).ToString();
            }
        }


        #region ControlsInGame
        private void ChessBoard_PlayerMark(object sender, EvenSentPoint e)
        {
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.SEND_POINT, e.Location, ""));
            Listen();
        }
        private void ChessBoard_EndGame(object sender, EventArgs e)
        {
            EndGame();
        }
        void Quit()
        {
            Application.Exit();
        }
        void NewGame()
        {
            ChessBoard.DrawChessBoard();
            ChessBoard.FindWiner = false;
            if (isMoreNewGame)
            {
                Random rag = new Random();
                int av = rag.Next(1, 8);
                ChangeAvatar(GameManager.isSever, av);
                GameManager.Socket.Send(new SocketData((int)Socket_Commmad.AVATARPLAYER, new Point(), av.ToString()));
            }
        }
        void ChangeAvatar(bool isSever, int av)
        {
            if (isSever)
            {
                AvatarPlayer1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\Avatar\" + av.ToString() + @".png");
            }
            else
            {
                AvatarPlayer2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\Avatar\" + av.ToString() + @".png");
            }
        }
        private void EndGame()
        {
            MessageBox.Show("End Game! Good job Bro");
            Chess_Board.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Warring", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            //else
            //{
            //    try
            //    {
            //        GameManager.Socket.Send(new SocketData((int)Socket_Commmad.QUIT, new Point(), ""));
            //    }
            //    catch { }
            //}
        }
        private void PbNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.NEW_GAME, new Point(), ""));
            Chess_Board.Enabled = true;
        }
        private void PbQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }
        #endregion

        #region Socket
        
        private void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)GameManager.Socket.Receive();
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
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Chess_Board.Enabled = true;
                        ChessBoard.PlayerMarkClick(data.Location);
                    }));
                    break;
                case (int)Socket_Commmad.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        Chess_Board.Enabled = false;
                    }));
                    break;
                case (int)Socket_Commmad.END_GAME:
                    break;
                case (int)Socket_Commmad.NOTIFY:
                    break;
                case (int)Socket_Commmad.QUIT:
                    MessageBox.Show("Người chơi đã thoát");
                    Chess_Board.Enabled = false;
                    break;
                case (int)Socket_Commmad.CHAT:
                    //formChat.richTextBox1.Text += "Player: " + data.Message + "\n";
                    break;
                case (int)Socket_Commmad.SURRENDER:
                    ChessBoard_GetPointForWiner(null, new EventPointWiner(int.Parse(data.Message)));
                    Chess_Board.Enabled = false;
                    break;
                case (int)Socket_Commmad.AVATARPLAYER:
                    ChangeAvatar(!GameManager.isSever, int.Parse(data.Message));
                    break;
            }
            Listen();
        }
        #endregion

        #region MultiChat
        bool CheckShowChat = false;
        private void PbChat_Click(object sender, EventArgs e)
        {
            if (!CheckShowChat)
            {
                formChat.Show();
                CheckShowChat = true;
            }
            else
            {
                formChat.Hide();
                CheckShowChat = false;
            }

        }
        #endregion

        private void PbSurrender_Click(object sender, EventArgs e)
        {
            EndGame();
            int winner;
            if (!GameManager.isSever)
                winner = 1;
            else
                winner = 2;
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.SURRENDER, new Point(), winner.ToString()));
            Chess_Board.Enabled = false;
            ChessBoard_GetPointForWiner(null, new EventPointWiner(winner));
        }
    }
}
