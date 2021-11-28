using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameCaro
{
    class Player
    {
        public static int turn = 0;
        string name;
        Image chess;
        public int Turn { get => turn; set => turn = value; }
        public string Name { get => name; set => name = value; }
        public Image Chess { get => chess; set => chess = value; }

        public Player(string name, Image chess)
        {
            this.Name = name;
            this.Chess = chess;
        }
    }
}
