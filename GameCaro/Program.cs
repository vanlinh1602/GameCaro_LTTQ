using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 gameDisplay = new Form1();
            //Form2 controlStart = new Form2();
            //GameManager.ControlStart = controlStart;
            GameManager.GameDisplay = gameDisplay;
            //Application.Run(controlStart);
            //if (GameManager.CheckOpen)
            //{
                Application.Run(gameDisplay);
            //}
            //Application.Run(new Form1());
        }
    }
}
