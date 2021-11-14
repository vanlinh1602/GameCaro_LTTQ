using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace GameCaro
{
    class GameManager
    {
        public static StartUp ControlStart;
        public static MainGame ControlGame;
        public static bool CheckOpenGame = false;
        public static string IP;
        public static bool isSever;
        public static SocketManager Socket;
        public static bool checkExitGame = false;
    }
}
