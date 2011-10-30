﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace Concert.DataAccessLayer
{
    class DBObjectController
    {
        public static ConcertEntities context;

        public static void SaveChanges()
        {
            context.SaveChanges();
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
            return context.Location;
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

		public static IEnumerable<Artist> GetAllArtists()
		{
			return context.Artist;
		}

		public static IEnumerable<Album> GetAllAlbums( )
		{
			return context.Album;
		}

        public static IEnumerable<Band> GetBandsByAlbum(Album album)
        {
            return context.Band.Where(b => b.Album.Contains(album));
        }

        public static IEnumerable<Album> GetAlbumsByTrack(Track track)
        {
            return context.Album.Where(a => a.Track.Contains(track)); 
        }

		public static IEnumerable<Concert> GetConcertsByBand( Band band )
		{
			return context.Concert.Where( c => c.Band.Contains( band ) );
		}

		public static IEnumerable<Band> GetAllBands( )
		{
            return context.Band;
		}

        public static IEnumerable<Band> GetBandsByArtist(Artist artist)
        {
            return context.Band.Where(b => b.Artist.Contains(artist));
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
