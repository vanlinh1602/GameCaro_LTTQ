﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        public static int Width = 27;
        public static int Height = 19;
        public static int Chess_Width = 30;
        public static int Chess_Height = 30;
        private Panel chess_Board = new Panel();
        List<List<Button>> matrix;
        event EventHandler<EvenSentPoint> playerMark;
        event EventHandler endGame;
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
        public event EventHandler EndGame
        {
            add
            {
                endGame += value;
            }
            remove
            {
                endGame -= value;
            }
        }

        public Panel Chess_Board { get => chess_Board; set => chess_Board = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<Point> StackUndo { get => stackUndo; set => stackUndo = value; }

        List<Player> players = new List<Player>()
        {
            new Player("Player 1", Image.FromFile(Application.StartupPath + @"\Resources\P1.jpg")),
            new Player("Player 2", Image.FromFile(Application.StartupPath + @"\Resources\P2.jpg"))
        };
        private Stack<Point> stackUndo = new Stack<Point>();
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
                    bnt.Click += Bnt_Click;
                    Chess_Board.Controls.Add(bnt);
                    oldBnt = bnt;
                    matrix[i].Add(bnt);
                }
                oldBnt.Location = new Point(0, oldBnt.Location.Y + Chess_Height);
                oldBnt.Height = 0;
                oldBnt.Width = 0;
            }
        }

        internal void Undo()
        {
            if (StackUndo.Count != 0) 
            {
                Point point = StackUndo.Pop();
                matrix[point.X][point.Y].BackgroundImage = null;
                ChangePlayer();
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
            bnt.BackgroundImage = players[Player.turn].Avatar;
            ChangePlayer();
            int x = int.Parse(bnt.Tag.ToString());
            int y = matrix[x].IndexOf(bnt);
            StackUndo.Push(new Point(x,y));
            if (playerMark != null)
            {
                playerMark(this, new EvenSentPoint(new Point(x,y)));
            }
        }
        private void Bnt_Click(object sender, EventArgs e)
        {
            Button bnt = sender as Button;
            ChangeImageAndChangePlayer(bnt);
            CheckEndGame(bnt);
        }
        public void PlayerMarkClick(Point point)
        {
            Button btn = matrix[point.X][point.Y];
            if (btn.BackgroundImage != null)
                return;
            btn.BackgroundImage = players[Player.turn].Avatar;
            ChangePlayer();
            int x = int.Parse(btn.Tag.ToString());
            int y = matrix[x].IndexOf(btn);
            StackUndo.Push(new Point(x, y));
            CheckEndGame(btn);
        }
        private void CheckEndGame(Button bnt)
        {
            if (isEndGame(bnt))
            {
                if (endGame != null)
                {
                    endGame(this, new EventArgs());
                }
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
}
