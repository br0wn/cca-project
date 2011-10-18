using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Album
    {
        private string name;
        private List<Song> songs;

        public string Name { get { return name; } set { name = value; } }

        public List<Song> Songs { get { return songs; } }

        public Album(string name)
        {
            Name = name;
            songs = new List<Song>();
        }

        public Album(string name, List<Song> songs)
        {
            Name = name;
            this.songs = songs;
        }

        public void AddTrack(Song song)
        {
            this.songs.Add(song);
        }

        public int NumOfTracks()
        {
            return songs.Count;
        }

        public override string ToString()
        {
            StringBuilder songList = new StringBuilder();
            songList.Append(name + "\r\n\t\t\tTracks : \r\n");
            for (int i = 0; i < songs.Count; i++)
            {
                songList.Append("\t\t\t\t#" + (i + 1) + ". " + songs[i] + "\r\n");
            }
            return songList.ToString();
        }
        public override bool Equals(object obj)
        {
            bool sameName = this.Name == ((Album) obj).Name;
            bool sameSongs = true;
            foreach (Song song in Songs)
            {
                foreach (Song song1 in ((Album) obj).Songs)
                {
                    if (!song.Equals(song1))
                    {
                        sameSongs = false;
                        break;
                    }
                }
                if (!sameSongs)
                {
                    break;
                }
            }
            return sameSongs && sameName;
        }
    }
}
