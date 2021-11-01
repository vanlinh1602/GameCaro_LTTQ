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
        public static MainGame GameDisplay;
        public static int Timer_Interval = 100;
        public static int Process_Step = 100;
        public static int Process_Maximun = 10000;
        public static bool CheckOpen = false;
    }
}
