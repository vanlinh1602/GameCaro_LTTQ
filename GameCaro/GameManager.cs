using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GameCaro
{
    class GameManager
    {
        public static Form2 ControlStart;
        public static MainGame GameDisplay;
        public static bool CheckOpen = false;
        public static int Timer_Interval = 100;
        public static int Process_Step = 100;
        public static int Process_Maximun = 10000;


        internal static void EndGame()
        {
            MessageBox.Show("End Game! Good job Bro");
        }

        internal static void UpdateNewTime(ref MainGame form1)
        {
            form1.TimeDown.Value = 0;
            form1.CountTime.Start();
        }

        public static void SetUpTimeDown(ref MainGame form1)
        {
            form1.TimeDown.Step = GameManager.Process_Step;
            form1.TimeDown.Maximum = GameManager.Process_Maximun;
            form1.CountTime.Interval = GameManager.Timer_Interval;
        }
    }
}
