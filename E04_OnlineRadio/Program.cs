using E04_OnlineRadio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_OnlineRadio
{
    public class Program
    {
        public static void Main()
        {
            var songsPlaylist = new List<Song>();

            var songNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < songNumber; i++)
            {
                var songArgs = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (songArgs.Count() != 3)
                {
                    Console.WriteLine("Invalid song.");
                    return;
                }

                var artistName = songArgs[0];
                var songName = songArgs[1];
                var songLength = songArgs[2];

                try
                {
                    var song = new Song(artistName, songName, songLength);
                    songsPlaylist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            PrintPlaylist(songsPlaylist);
        }

        private static void PrintPlaylist(List<Song> playlist)
        {
            var allSeconds = playlist.Select(s => s.LengthSec).Sum();
            var secondsPerMinutes = allSeconds / 60;
            var totalSeconds = allSeconds % 60;

            var allMinutes = playlist.Select(m => m.LengthMin).Sum() + secondsPerMinutes;
            var totalHours = allMinutes / 60;
            var totalMinutes = allMinutes % 60;

            Console.WriteLine($"Songs added: {playlist.Count()}");
            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}