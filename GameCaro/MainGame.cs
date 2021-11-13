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
        Winner formWinner = new Winner();
        Loser formLoser = new Loser();
        bool isMoreNewGame = false;
        public MainGame()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            ChessBoard = new ChessBoardManager(Chess_Board);
            formChat = new Chat();
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
            ChessBoard.GetPointForWiner += ChessBoard_GetPointForWiner;
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
        #region ControlsInGame
        private void ChessBoard_PlayerMark(object sender, EvenSentPoint e)
        {
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.SEND_POINT, e.Location, ""));
            Listen();
        }
        void Quit()
        {
            Exit exit = new Exit();
            exit.ShowDialog();
            if (GameManager.checkExitGame)
            {
                Close();
            }
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
        private void PbSurrender_Click(object sender, EventArgs e)
        {
            Chess_Board.Enabled = false;
            int winner;
            if (!GameManager.isSever)
                winner = 1;
            else
                winner = 2;
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.SURRENDER, new Point(), winner.ToString()));
            Chess_Board.Enabled = false;
            ChessBoard_GetPointForWiner(null, new EventPointWiner(winner));
        }
        void ShowFormLose()
        {
            Thread showform = new Thread(() => {
                formLoser.ShowDialog();
            });
            showform.IsBackground = true;
            showform.Start();
        }
        void ShowFormWin()
        {
            Thread showform = new Thread(() => {
                formWinner.ShowDialog();
            });
            showform.IsBackground = true;
            showform.Start();
        }
        private void ChessBoard_GetPointForWiner(object sender, EventPointWiner e)
        {
            Chess_Board.Enabled = false;
            if (e.Winer == 1)
            {
                PointLayer1.Text = (int.Parse(PointLayer1.Text) + 1).ToString();
                if (GameManager.isSever)
                {
                    ShowFormWin();
                }
                else
                {
                    ShowFormLose();
                }
            }
            else
            {
                PointLayer2.Text = (int.Parse(PointLayer2.Text) + 1).ToString();
                if (!GameManager.isSever)
                {
                    ShowFormWin();
                }
                else
                {
                    ShowFormLose();
                }
            }
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

        
    }
}
