using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace Concert.DataAccessLayer
{
    class DBObjectController
    {

        public static void SaveChanges()
        {
            context.SaveChanges();
        }

        public static void DeleteObject(Concert concert)
        {
            foreach (Band band in context.Band)
            {
                if (band.Concert.Contains(concert))
                {
                    band.Concert.Remove(concert);
                }
            }

            context.Concert.DeleteObject(concert);
            SaveChanges();
        }

        public static void StoreObject(Concert concert)
        {
            context.Concert.AddObject(concert);
            SaveChanges();
        }

        public static IEnumerable<Concert> GetAllConcerts()
        {
            return context.Concert;
        }

        public static IEnumerable<Concert> GetCustomConcerts(string name, int fromPrice, int toPrice, DateTime fromDate, DateTime toDate)
        {
            List<Concert> concerts = new List<Concert>();
            if (!string.IsNullOrEmpty(name))
            {
                foreach (Concert concert in context.Concert.Where(c => c.Name.ToLower().Contains(name.ToLower()) &&
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
                foreach (Concert concert in context.Concert.Where(c => c.TicketPrice >= fromPrice &&
                                                                       c.TicketPrice <= toPrice   &&
                                                                       c.Date >= fromDate         &&
                                                                       c.Date <= toDate))
                {
                    concerts.Add(concert);
                }
            }
            return concerts;
        }

        public static void DeleteObject(Location location)
        {
            context.Location.DeleteObject(location);
            SaveChanges();
        }

        public static void StoreObject(Location location)
        {
            context.Location.AddObject(location);
            SaveChanges();
        }
        
        public static IEnumerable<Location> GetAllLocations()
        {
            return context.Location;
        }

        public static void DeleteObject(Track track)
        {
            context.Track.DeleteObject(track);
            SaveChanges();
        }

        public static void StoreObject(Track track)
        {
            context.Track.AddObject(track);
            SaveChanges();
        }

        public static IEnumerable<Track> GetAllTracks()
        {
            return context.Track;
        }

        public static IEnumerable<Track> GetAvailableTracks()
        {
            List<Track> availableSongs = new List<Track>();
            IEnumerable<Album> albums = GetAllAlbums();
            foreach (Track track in GetAllTracks())
            {
                bool available = true;
                foreach (Album album in albums)
                {
                    if (album.Track.Contains(track))
                    {
                        available = false;
                        break;
                    }
                }
                if (available)
                {
                    availableSongs.Add(track);
                }
            }
            return availableSongs;
        }

        public static void DeleteObject(Artist artist)
        {
            foreach (Instrument instrument in context.Instrument)
            {
                if (instrument.Artist.Contains(artist))
                {
                    instrument.Artist.Remove(artist);
                }
            }

            foreach (Band band in context.Band)
            {
                if (band.Artist.Contains(artist))
                {
                    band.Artist.Remove(artist);
                }
            }

            context.Artist.DeleteObject(artist);
            SaveChanges();
        }

        public static void StoreObject(Artist artist)
        {
            context.Artist.AddObject(artist);
            SaveChanges();
        }

		public static IEnumerable<Artist> GetAllArtists()
		{
			return context.Artist;
		}

        public static void DeleteObject(Album album)
        {
            List<int> tracks = new List<int>();
            foreach (Track track in album.Track)
            {
                tracks.Add(track.Id);
            }

            context.Album.DeleteObject(album);
            SaveChanges();

            foreach (Track track in context.Track.Where(t => tracks.Contains(t.Id)))
            {
                DeleteObject(track);
            }
            SaveChanges();
        }

        public static void StoreObject(Album album)
        {
            context.Album.AddObject(album);
            SaveChanges();
        }

		public static IEnumerable<Album> GetAllAlbums( )
		{
			return context.Album;
		}

        public static void DeleteObject(Band band)
        {
            foreach (Artist artist in context.Artist)
            {
                if (artist.Band.Contains(band))
                {
                    artist.Band.Remove(band);
                }
            }

            foreach (Concert concert in context.Concert)
            {
                if (concert.Band.Contains(band))
                {
                    concert.Band.Remove(band);
                }
            }

            List<int> albums = new List<int>();

            foreach (Album album in band.Album)
            {
                albums.Add(album.Id);
            }

            context.Band.DeleteObject(band);
            SaveChanges();

            foreach (Album album in context.Album.Where(a => albums.Contains(a.Id)))
            {
                DeleteObject(album);
            }
            SaveChanges();
        }

        public static void StoreObject(Band band)
        {
            context.Band.AddObject(band);
            SaveChanges();
        }

		public static IEnumerable<Band> GetAllBands( )
		{
            return context.Band;
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

        public static void DeleteObject(Instrument instrument)
        {
            foreach (Artist artist in context.Artist)
            {
                if (artist.Instrument.Contains(instrument))
                {
                    artist.Instrument.Remove(instrument);
                }
            }

            context.Instrument.DeleteObject(instrument);
            SaveChanges();
        }

        public static void StoreObject(Instrument instrument)
        {
            context.Instrument.AddObject(instrument);
            SaveChanges();
        }

        public static IEnumerable<Instrument> GetAllInstruments()
        {
            return context.Instrument;
        }

        public static void DeleteObject(Country country)
        {
            List<int> locations = new List<int>();

            foreach (Location location in country.Location)
            {
                locations.Add(location.Id);
            }

            context.Country.DeleteObject(country);
            SaveChanges();

            foreach (Location location in context.Location.Where(l => locations.Contains(l.Id)))
            {
                DeleteObject(location);
            }
            SaveChanges();
        }

        public static void StoreObject(Country country)
        {
            context.Country.AddObject(country);
            SaveChanges();
        }

        public static IEnumerable<Country> GetAllCountries()
        {
            return context.Country.OrderBy(c => c.Name);
        }
    }
}
