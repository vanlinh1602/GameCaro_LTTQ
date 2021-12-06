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
        Setting setting = new Setting();
        bool isMoreNewGame = false;
        public static bool isPlayerConnect = false;
        public MainGame()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            ChessBoard = new ChessBoardManager(Chess_Board);
            formChat = new Chat();
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
            ChessBoard.GetPointForWiner += ChessBoard_GetPointForWiner;
            ChangeAvatar(true, 1);
            ChangeAvatar(false, 2);
            if (!GameManager.isSever)
            {
                //Chess_Board.Enabled = false;
                isPlayerConnect = true;
                label2.Text = GameManager.name;
                Listen();
                GameManager.Socket.Send(new SocketData(((int)Socket_Commmad.SETUP_NAME), new Point(), GameManager.name));
            }
            else
            {
                label1.Text = GameManager.name;
                Thread thread = new Thread(() =>
                {
                    while (GameManager.Socket.client == null)
                    {

                    }
                    this.Invoke((MethodInvoker)(() =>
                    {
                        isPlayerConnect = true;
                        Listen();
                        GameManager.Socket.Send(new SocketData(((int)Socket_Commmad.SETUP_NAME), new Point(), GameManager.name));
                    }));
                });
                thread.IsBackground = true;
                thread.Start();
            }
        }
        #region ControlsInGame
        private void SetAllow()
        {
            if (!ChessBoardManager.isAllow)
            {
                if (GameManager.isSever)
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Crimson;
                }
                else
                {
                    label1.ForeColor = Color.Crimson;
                    label2.ForeColor = Color.Black;
                }
            }
            else
            {
                if (GameManager.isSever)
                {
                    label2.ForeColor = Color.Black;
                    label1.ForeColor = Color.Crimson;
                }
                else
                {
                    label2.ForeColor = Color.Crimson;
                    label1.ForeColor = Color.Black;
                }
            }
            
        }
        private void ChessBoard_PlayerMark(object sender, EvenSentPoint e)
        {
            ChessBoardManager.isAllow = false;
            SetAllow();
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.SEND_POINT, e.Location, ""));
            Listen();
        }
        void Quit()
        {
            this.Close();
        }
        void NewGame()
        {
            SetAllow();
            if (!isMoreNewGame)
                Chess_Board.BackgroundImage = null;
            else
            {
                Random rag = new Random();
                int av = rag.Next(1, 8);
                ChangeAvatar(GameManager.isSever, av);
                GameManager.Socket.Send(new SocketData((int)Socket_Commmad.AVATARPLAYER, new Point(), av.ToString()));
            }
            ChessBoard.DrawChessBoard();
            ChessBoard.FindWiner = false;
        }
        //Change Avatar Player when New Game
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
            if (!ChessBoard.checkEndGame)
            {
                if(isMoreNewGame)
                    return;
            }
            if (!isPlayerConnect)
                return;
            ChessBoardManager.isAllow = true;
            NewGame();
            GameManager.Socket.Send(new SocketData((int)Socket_Commmad.NEW_GAME, new Point(), ""));
            Chess_Board.Enabled = true;
            if (!isMoreNewGame)
            {
                isMoreNewGame = true;
            }
            ChessBoard.checkEndGame = false;
        }
        private void Surrender()
        {
            ChessBoard.checkEndGame = true;
            if (!isMoreNewGame)
                return;
            if (!isPlayerConnect)
                return;
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
                        ChessBoardManager.isAllow = true;
                        SetAllow();
                        ChessBoard.PlayerMarkClick(data.Location);
                    }));
                    break;
                case (int)Socket_Commmad.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        ChessBoardManager.isAllow = false;
                        NewGame();
                        isMoreNewGame = true;
                    }));
                    break;
                case (int)Socket_Commmad.SETUP_NAME:
                    if (GameManager.isSever){
                        label2.Text = data.Message;
                    }
                    else
                    {
                        label1.Text = data.Message;
                    }
                    break;
                case (int)Socket_Commmad.QUIT:
                    Chess_Board.Enabled = false;
                    isPlayerConnect = false;
                    MessageBox.Show("Player has exited", "Notification");
                    break;
                case (int)Socket_Commmad.CHAT:
                    formChat.chatDisplay.Text += "Player: " + data.Message + "\n";
                    break;
                case (int)Socket_Commmad.SURRENDER:
                    ChessBoard.checkEndGame = true;
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

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
            if (GameManager.checkExitGame)
            {
                if (isPlayerConnect)
                    GameManager.Socket.Send(new SocketData((int)Socket_Commmad.QUIT, new Point(), ""));
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void SettingBTN_Click(object sender, EventArgs e)
        {
            setting.ShowDialog();
            if (setting.CheckSurrender)
            {
                Surrender();
                setting.CheckSurrender = false;
            }
        }

        private void GachaBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
