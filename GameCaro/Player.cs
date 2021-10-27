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
        Image avatar;
        public int Turn { get => turn; set => turn = value; }
        public string Name { get => name; set => name = value; }
        public Image Avatar { get => avatar; set => avatar = value; }

        public Player(string name, Image avatar)
        {
            this.Name = name;
            this.Avatar = avatar;
        }
    }
}
