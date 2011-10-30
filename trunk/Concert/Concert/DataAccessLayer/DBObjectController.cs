using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concert.DBObjectDefinition;
using System.Data.Objects;

namespace Concert.DataAccessLayer
{
    class DBObjectController
    {
        public static ObjectContext context;

        public static void StoreObject(object obj)
        {
            db.Store(obj);
			db.Commit();
        }

        public static void DeleteObject(object obj)
        {
            db.Delete(obj);
            db.Commit();
        }

        public static IEnumerable<DBObjectDefinition.Concert> GetAllConcerts()
        {
            return db.Query<DBObjectDefinition.Concert>(c => true);
        }

        public static IEnumerable<DBObjectDefinition.Concert> GetCustomConcerts(string name, int fromPrice, int toPrice, DateTime fromDate, DateTime toDate)
        {
            List<DBObjectDefinition.Concert> concerts = new List<DBObjectDefinition.Concert>();
            if (!string.IsNullOrEmpty(name))
            {
                foreach (DBObjectDefinition.Concert concert in db.Query<DBObjectDefinition.Concert>(c => c.Name.ToLower().Contains(name.ToLower()) &&
                                                                                                         c.TicketPrice >= fromPrice                &&
                                                                                                         c.TicketPrice <= toPrice                  &&
                                                                                                         c.Date >= fromDate                        &&
                                                                                                         c.Date <= toDate ))
                {
                    concerts.Add(concert);
                }
            }
            else
            {
                foreach (DBObjectDefinition.Concert concert in db.Query<DBObjectDefinition.Concert>(c => c.TicketPrice >= fromPrice &&
                                                                                                         c.TicketPrice <= toPrice &&
                                                                                                         c.Date >= fromDate &&
                                                                                                         c.Date <= toDate))
                {
                    concerts.Add(concert);
                }
            }
            return concerts;
        }

        public static IEnumerable<Location> GetAllLocations()
        {
            return db.Query<Location>(l => true);
        }

        public static IEnumerable<Song> GetAllTracks()
        {
            return db.Query<Song>(s => true);
        }

        public static IEnumerable<Song> GetAvailableTracks()
        {
            List<Song> availableSongs = new List<Song>();
            IEnumerable<Album> albums = GetAllAlbums();
            foreach (Song song in GetAllTracks())
            {
                bool available = true;
                foreach (Album album in albums)
                {
                    if (album.Songs.Contains(song))
                    {
                        available = false;
                        break;
                    }
                }
                if (available)
                {
                    availableSongs.Add(song);
                }
            }
            return availableSongs;
        }

		public static IEnumerable<Artist> GetAllArtists()
		{
			return db.Query<Artist>( a => true );
		}

		public static IEnumerable<Album> GetAllAlbums( )
		{
			return db.Query<Album>( a => true );
		}

        public static IEnumerable<Band> GetBandsByAlbum(Album album)
        {
            return db.Query<Band>(a => a.Albums.Contains(album));
        }

        public static IEnumerable<Album> GetAlbumsByTrack(Song track)
        {
            return db.Query<Album>(a => a.Songs.Contains(track)); 
        }

		public static IEnumerable<Concert.DBObjectDefinition.Concert> GetConcertsByBand( Band band )
		{
			return db.Query<Concert.DBObjectDefinition.Concert>( c => c.Bands.Contains( band ) );
		}

		public static IEnumerable<Band> GetAllBands( )
		{
			return db.Query<Band>( b => true );
		}

        public static IEnumerable<Band> GetBandsByArtist(Artist artist)
        {
            return db.Query<Band>(b => b.Artist.Contains(artist));
        }

        public static IEnumerable<Band> GetAdjectiveBands(IEnumerable<Band> bands)
        {
            List<Band> adjectiveBands = new List<Band>();
            adjectiveBands.AddRange(GetAllBands());
            foreach (Band band in bands)
            {
                adjectiveBands.Remove(band);
            }
            return adjectiveBands;
        }
    }
}
