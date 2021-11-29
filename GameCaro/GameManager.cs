﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using System.Media;

namespace GameCaro
{
    class GameManager
    {
        public static SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\Resources\MusicInGame.wav");
        public static StartUp ControlStart;
        public static MainGame ControlGame;
        public static bool CheckOpenGame = false;
        public static string name;
        public static string IP;
        public static bool isSever;
        public static SocketManager Socket = new SocketManager();
        public static bool checkExitGame = false;
    }
}
