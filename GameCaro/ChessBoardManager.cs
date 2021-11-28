using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        public static int Width = 60;
        public static int Height = 40;
        public static int Chess_Width = 30;
        public static int Chess_Height = 30;
        public int PlayerWin;
        public bool FindWiner;
        private Panel chess_Board = new Panel();
        private List<List<Button>> matrix;
        private List<Player> players = new List<Player>()
        {
            new Player("Player 1", Image.FromFile(Application.StartupPath + @"\Resources\P1.jpg")),
            new Player("Player 2", Image.FromFile(Application.StartupPath + @"\Resources\P2.jpg"))
        };
        event EventHandler<EvenSentPoint> playerMark;
        event EventHandler<EventPointWiner> getPointForWiner;
        public event EventHandler<EvenSentPoint> PlayerMark
        {
            add
            {
                playerMark += value;
            }
            remove
            {
                playerMark -= value;
            }
        }
        public event EventHandler<EventPointWiner> GetPointForWiner
        {
            add
            {
                getPointForWiner += value;
            }
            remove
            {
                getPointForWiner -= value;
            }
        }
        public Panel Chess_Board { get => chess_Board; set => chess_Board = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chess_Board)
        {
            this.chess_Board = chess_Board;
        }

        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            matrix = new List<List<Button>>();
            Chess_Board.Controls.Clear();
            Chess_Board.Enabled = true;
            Button oldBnt = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < Height; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < Width; j++)
                {
                    Button bnt = new Button()
                    {
                        Height = Chess_Height,
                        Width = Chess_Width,
                        Location = new Point(oldBnt.Location.X + oldBnt.Width, oldBnt.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                    };
                    bnt.Click += Btn_Click;
                    Chess_Board.Controls.Add(bnt);
                    oldBnt = bnt;
                    matrix[i].Add(bnt);
                }
                oldBnt.Location = new Point(0, oldBnt.Location.Y + Chess_Height);
                oldBnt.Height = 0;
                oldBnt.Width = 0;
            }
        }
        private void ChangePlayer()
        {
            Player.turn = Player.turn == 1 ? 0 : 1;
        }
        private void ChangeImageAndChangePlayer(Button bnt)
        {
            if (bnt.BackgroundImage != null)
                return;
            bnt.BackgroundImage = players[Player.turn].Chess;
            ChangePlayer();
            int x = int.Parse(bnt.Tag.ToString());
            int y = matrix[x].IndexOf(bnt);
            if (playerMark != null)
            {
                playerMark(this, new EvenSentPoint(new Point(x,y)));
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button bnt = sender as Button;
            Chess_Board.Enabled = false;
            ChangeImageAndChangePlayer(bnt);
            bnt.Enabled = false;
            CheckEndGame(bnt);
            if (FindWiner)
            {
                if (getPointForWiner != null)
                {
                    if (GameManager.isSever)
                    {
                        this.getPointForWiner(this, new EventPointWiner(1));
                    }
                    else
                    {
                        this.getPointForWiner(this, new EventPointWiner(2));
                    }
                }

            }
        }
        public void PlayerMarkClick(Point point)
        {
            Button btn = matrix[point.X][point.Y];
            if (btn.BackgroundImage != null)
                return;
            btn.BackgroundImage = players[Player.turn].Chess;
            ChangePlayer();
            btn.Enabled = false;
            CheckEndGame(btn);
            if (FindWiner)
            {
                if (getPointForWiner != null)
                {
                    if (GameManager.isSever)
                    {
                        this.getPointForWiner(this, new EventPointWiner(2));
                    }
                    else
                    {
                        this.getPointForWiner(this, new EventPointWiner(1));

                    }
                }
                
            }
        }
        private void CheckEndGame(Button bnt)
        {
            if (isEndGame(bnt))
            {
                FindWiner = true;
            }
        }
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }
        private bool isEndSub(object btn)
        {
            Button button = btn as Button;
            int x = Convert.ToInt32(button.Tag);
            int y = matrix[x].IndexOf(button);
            int countUp = 0;
            for (int i = 0; i <= Width - y; i++)
            {
                if (x - i < 0 || y + i >= Width)
                    break;
                if (matrix[x - i][y + i].BackgroundImage == button.BackgroundImage)
                {
                    countUp++;
                }
                else
                    break;
            }
            int countDown = 0;
            for (int i = 1; i <= y; i++)
            {
                if (x + i >= Height || y - i < 0)
                    break;
                if (matrix[x + i][y - i].BackgroundImage == button.BackgroundImage)
                {
                    countDown++;
                }
                else
                    break;
            }
            return countUp + countDown == 5 ? true : false;
        }
        private bool isEndPrimary(object btn)
        {
            Button button = btn as Button;
            int x = Convert.ToInt32(button.Tag);
            int y = matrix[x].IndexOf(button);
            int countUp = 0;
            for (int i = 0; i <= y; i++)
            {
                if (x - i < 0 || y - i  < 0)
                    break;
                if (matrix[x-i][y-i].BackgroundImage == button.BackgroundImage)
                {
                    countUp++;
                }
                else
                    break;
            }
            int countDown = 0;
            for (int i = 1; i <= Width-y; i++)
            {
                if (x + i >= Height || y + i >= Width)
                    break;
                if (matrix[x + i][y + i].BackgroundImage == button.BackgroundImage)
                {
                    countDown++;
                }
                else
                    break;
            }
            return countUp + countDown == 5 ? true : false;
        }
        private bool isEndVertical(object btn)
        {
            Button button = btn as Button;
            int x = Convert.ToInt32(button.Tag);
            int y = matrix[x].IndexOf(button);
            int countLeft = 0;
            for (int i = x; i >= 0; i--)
            {

                if (matrix[i][y].BackgroundImage == button.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = x + 1; i < Height; i++)
            {
                if (matrix[i][y].BackgroundImage == button.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5 ? true : false;
        }
        private bool isEndHorizontal(object btn)
        {
            Button button = btn as Button;
            int x = Convert.ToInt32(button.Tag);
            int y = matrix[x].IndexOf(button);
            int countLeft = 0;
            for (int i = y; i >= 0; i--)
            {
                if (matrix[x][i].BackgroundImage == button.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = y + 1; i < Width; i++)
            {
                if (matrix[x][i].BackgroundImage == button.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5 ? true : false;
        }
        #endregion
    }
    public class EvenSentPoint : EventArgs
    {
        private Point location = new Point();
        public Point Location { get => location; set => location = value; }
        public EvenSentPoint(Point location)
        {
            this.location = location;
        }
    }
    public class EventPointWiner : EventArgs
    {
        private int winer;
        public int Winer { get => winer; set => winer = value; }
        public EventPointWiner(int winer)
        {
            this.winer = winer;
        }
    }
}
