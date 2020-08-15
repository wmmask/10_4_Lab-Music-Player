using System;
using System.Collections.Generic;
using System.Text;

namespace _10_4_Lab_Music_Player
{
    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}
