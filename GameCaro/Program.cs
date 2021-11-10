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
            GameManager.Socket = new SocketManager();
            GameManager.ControlStart = new StartUp();
            /*Application.Run(GameManager.ControlStart);
            if (GameManager.CheckOpenGame)
            {
                GameManager.ControlGame = new MainGame();
                Application.Run(GameManager.ControlGame);
            }*/
            Application.Run(new Winner());
        }
    }
}
