using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace GameCaro
{
    class MediaManager
    {
        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        public string url = Application.StartupPath + @"Resources\MusicInGame.mp3";

        public MediaManager()
        {
            mediaPlayer.settings.volume = 50;
        }

        public void Start()
        {
            mediaPlayer.controls.pause();
            mediaPlayer.URL = url;
            mediaPlayer.controls.play();
        }
        public void VolumeUp()
        {
            if (mediaPlayer.settings.volume < 90)
            {
                mediaPlayer.settings.volume = (mediaPlayer.settings.volume + 10);
            }
        }
        public void VolumeDown()
        {
            if (mediaPlayer.settings.volume > 1)
            {
                mediaPlayer.settings.volume = (mediaPlayer.settings.volume - (mediaPlayer.settings.volume / 2));
            }
        }
    }
}
