using System;

namespace E04_OnlineRadio.Models
{
    public class Song
    {
        private int minArtistNameLength = 3;
        private int maxArtistNameLength = 20;
        private int minSongNameLength = 3;
        private int maxSongNameLength = 30;
        private int minSongLength = 0;
        private int maxSongLengthMin = 14;
        private int maxSongLengthSec = 59;

        private string artistName;
        private string songName;
        private int lengthMin;
        private int lengthSec;

        public Song(string artistName, string songName, string songLength)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongLength = songLength;
        }

        private string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < minArtistNameLength || value.Length > maxArtistNameLength)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
            }
        }

        private string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < minSongNameLength || value.Length > maxSongNameLength)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }
            }
        }

        public string SongLength
        {
            set
            {
                var lengthArgs = value.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (lengthArgs.Length != 2)
                {
                    throw new ArgumentException("Invalid song length.");
                }

                int songMin;
                int songSec;
                var isLengthMin = int.TryParse(lengthArgs[0], out songMin);
                var isLengthSec = int.TryParse(lengthArgs[1], out songSec);

                if (!isLengthMin || !isLengthSec)
                {
                    throw new ArgumentException("Invalid song length.");
                }

                this.LengthMin = songMin;
                this.LengthSec = songSec;
            }
        }

        public int LengthMin
        {
            get { return this.lengthMin; }
            private set
            {
                if (value < minSongLength || value > maxSongLengthMin)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }
                this.lengthMin = value;
            }
        }

        public int LengthSec
        {
            get { return this.lengthSec; }
            private set
            {
                if (value < minSongLength || value > maxSongLengthSec)
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }
                this.lengthSec = value;
            }
        }
    }
}