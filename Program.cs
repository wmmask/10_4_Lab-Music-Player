using System;

namespace _10_4_Lab_Music_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Creating a media player and an artist
            Artist prince = new Artist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(prince);

            // Audio book and media player
            AudioBook howto = new AudioBook("How to Win Friends and Influence People", "Dale Carnegie");
            player.PlayMedia(howto);

            //Sound track and media player
            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);




        }
    }
}
