using System;
using System.Collections.Generic;
using System.Text;

namespace _10_4_Lab_Music_Player
{
    class MovieSoundTrack : IAudioPlayer
    {
        public string movieName { get; }
        public string trackName { get; private set; }

        public MovieSoundTrack(string movieName)
        {
            this.movieName = movieName;
        }

        public void SelectTrack(string track)
        {
            trackName = track;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now playing: ");
            sb.Append(movieName);
            sb.Append(" ");
            sb.Append(trackName);
            Console.WriteLine(sb.ToString());
        }

    }
}
