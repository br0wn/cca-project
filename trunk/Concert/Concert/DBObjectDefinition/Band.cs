using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Band
    {
        private string name;
        private List<Artist> artists;
        private List<Album> albums;

        public List<Artist> Artist { get { return artists; } }
        public List<Album> Albums { get { return albums; } }
        public string Name { get { return name; } set { name = value; } }

        public Band(string name)
        {
            Name = name;
            this.artists = new List<Artist>();
            this.albums = new List<Album>();
        }

        public Band(string name, List<Artist> artists, List<Album> albums)
        {
            Name = name;
            this.artists = artists;
            this.albums = albums;
        }

        public void AddArtist(Artist artist)
        {
            this.artists.Add(artist);
        }

        public void AddAlbum(Album album)
        {
            this.albums.Add(album);
        }

        public override string ToString()
        {
            StringBuilder bandList = new StringBuilder();
            bandList.Append("\t\tName    : " + name + "\r\n\t\tArtists :\r\n");
            for (int i = 0; i < artists.Count; i++)
            {
                bandList.Append("\t\t\t" + (i + 1) + ": " + artists[i] + "\r\n");
            }
            bandList.Append("\t\tAlbums :");
            for (int i = 0; i < albums.Count; i++)
            {
                bandList.Append("\r\n\t\t\t" + (i + 1) + ". " + albums[i] + "\r\n");
            }
            return bandList.ToString();
        }
    }
}
