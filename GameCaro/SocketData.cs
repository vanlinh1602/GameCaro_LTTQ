using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameCaro
{   [Serializable]
    class SocketData
    {
        private int command;
        public int Command { get => command; set => command = value; }
        private Point location;
        public Point Location { get => location; set => location = value; }
        public string Message { get => message; set => message = value; }
        string message;

        public SocketData(int command, Point location, string message)
        {
            this.command = command;
            this.location = location;
            this.message = message;
        }
        
    }
    public enum Socket_Commmad
    {
        SEND_POINT,
        NEW_GAME,
        SURRENDER,
        QUIT,
        AVATARPLAYER,
        CHAT
    }
}
