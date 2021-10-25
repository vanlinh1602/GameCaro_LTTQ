using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();
        }

        void DrawChessBoard()
        {
            Button oldBnt = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < ChessBoardManager.Height; i++)
            {
                for (int j = 0; j < ChessBoardManager.Width; j++)
                {
                    Button bnt = new Button()
                    {
                        Height = ChessBoardManager.Chess_Height,
                        Width = ChessBoardManager.Chess_Width,
                        Location = new Point(oldBnt.Location.X + oldBnt.Width, oldBnt.Location.Y)
                    };
                    Chess_Board.Controls.Add(bnt);
                    oldBnt = bnt;
                }
                oldBnt.Location = new Point(0, oldBnt.Location.Y + ChessBoardManager.Chess_Height);
                oldBnt.Height = 0;
                oldBnt.Width = 0;
            }
        }
    }
}
