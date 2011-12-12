using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concert.DBObjectDefinition;

namespace Concert.DataAccessLayer
{
    class DBObjectController
    {
        const string XML_PATH    = "../../Resources/XML/Concert.xml";
        const string SCHEMA_PATH = "../../Resources/XML/ConcertSchema.xsd";

        private static XDocument db;
        private static XmlSchemaSet schema;

        public static void InitializeDataBase()
        {
            try
            {
                db = XDocument.Load(XML_PATH);
                schema = new XmlSchemaSet();
                schema.Add("", XmlReader.Create(new StreamReader(SCHEMA_PATH)));
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Failed to read xml or xsd document.\r\n" + 
                                              "Check paths:\r\n\t" + 
                                              ".xml: {0}\r\n\t" + 
                                              ".xsd: {1}\r\n" + 
                                              "Error message :\r\n" + 
                                              "###############\r\n" +
                                              "{2}", XML_PATH, SCHEMA_PATH, e.Message));
            }
            ValidateDatabase();
        }

        private static XElement GetElement(int ID, string Xname)
        {
            IEnumerable<XElement> objects = from o in db.Descendants(Xname)
                                            where int.Parse(o.Element("ID").Value) == ID
                                            select o;
            if (objects.Count() == 0)
                return null;
            else
                return objects.First();
        }

        private static int GetElementID(string elementName)
        {
            var query = from c in db.Descendants(elementName)
                        select int.Parse(c.Element("ID").Value);

            if (query.Count() == 0)
                return 1;
            else
                return query.Max() + 1;
        }

        private static bool ValidateDatabase(XElement element)
        {
            string errorMessage = "";
            bool errors = false;
            db.Validate(schema, (o, e) =>
            {
                errorMessage += e.Message; 
                errors = true;
            });
            
            if (errors)
            {
                MessageBox.Show("Invalid XML document\r\n" + errorMessage );
                element.Remove();
            }

            return !errors;
        }

        public static bool ValidateDatabase()
        {
            string errorMessage = "";
            bool errors = false;
            db.Validate(schema, (o, e) =>
            {
                errorMessage += e.Message;
                errors = true;
            });

            if (errors)
            {
                MessageBox.Show("Invalid XML document\r\n" + errorMessage);
            }

            return !errors;
        }

        public static void SaveChanges()
        {
            db.Save(XML_PATH);
        }

        public static void DeleteElement(XElement element)
        {
            element.Remove();

            ValidateDatabase();
        }

    //    public static void DeleteObject(Concert concert)
    //    {
    //        foreach (Band band in context.Band)
    //        {
    //            if (band.Concert.Contains(concert))
    //            {
    //                band.Concert.Remove(concert);
    //            }
    //        }

    //        context.Concert.DeleteObject(concert);
    //        SaveChanges();
    //    }

    //    public static void StoreObject(Concert concert)
    //    {
    //        context.Concert.AddObject(concert);
    //        SaveChanges();
    //    }

    //    public static IEnumerable<Concert> GetAllConcerts()
    //    {
    //        return context.Concert;
    //    }

    //    public static IEnumerable<Concert> GetCustomConcerts(string name, int fromPrice, int toPrice, DateTime fromDate, DateTime toDate)
    //    {
    //        List<Concert> concerts = new List<Concert>();
    //        if (!string.IsNullOrEmpty(name))
    //        {
    //            foreach (Concert concert in context.Concert.Where(c => c.Name.ToLower().Contains(name.ToLower()) &&
    //                                                                   c.TicketPrice >= fromPrice                &&
    //                                                                   c.TicketPrice <= toPrice                  &&
    //                                                                   c.Date >= fromDate                        &&
    //                                                                   c.Date <= toDate ))
    //            {
    //                concerts.Add(concert);
    //            }
    //        }
    //        else
    //        {
    //            foreach (Concert concert in context.Concert.Where(c => c.TicketPrice >= fromPrice &&
    //                                                                   c.TicketPrice <= toPrice   &&
    //                                                                   c.Date >= fromDate         &&
    //                                                                   c.Date <= toDate))
    //            {
    //                concerts.Add(concert);
    //            }
    //        }
    //        return concerts;
    //    }

        public static void DeleteObject(Location location)
        {
            IEnumerable<XElement> concerts = from c in db.Descendants("Concert")
                                             where int.Parse(c.Element("LocationID").Value) == location.ID
                                             select c;

            foreach (XElement concert in concerts)
            {
                concert.Element("LocationID").Value = string.Empty;
            }

            DeleteElement(GetElement(location.ID, "Location"));
        }

        public static void StoreObject(Location location)
        {
            if (location.ID != 0)
                GetElement(location.ID, "Location").Remove();
            else
                location.ID = GetElementID("Location");

            XElement xLocations = db.Descendants("Locations").First();

            xLocations.Add(location.toXML());
        }


        public static IEnumerable<Location> GetAllLocations()
        {
            return from l in db.Descendants("Location")
                    select new Location()
                    {
                        ID         = int.Parse(l.Element("ID").Value),
                        SeatCount  = int.Parse(l.Element("SeatCount").Value),
                        PostalCode = int.Parse(l.Element("PostalCode").Value),
                        Address    = l.Element("Address").Value,
                        Country = new Country()
                        {
                            ID = int.Parse(db.Descendants("Country").Where(c => c.Element("ID").Value == l.Element("CountryID").Value).First().Element("ID").Value),
                            Name = db.Descendants("Country").Where(c => c.Element("ID").Value == l.Element("CountryID").Value).First().Element("Name").Value
                        }
                    };
        }

        public static void DeleteObject(Track track)
        {
            DeleteElement(GetElement(track.ID, "Track"));
        }

        public static void StoreObject(Track track)
        {
            if (track.ID != 0)
                GetElement(track.ID, "Track").Remove();
            else
            {
                track.ID = GetElementID("Track");
            }

            XElement xTracks = db.Descendants("Tracks").First();

            xTracks.Add(track.toXML());
        }

        public static IEnumerable<Track> GetAllTracks()
        {
            return from t in db.Descendants("Track")
                   select new Track() 
                   {
                       ID = int.Parse(t.Element("ID").Value),
                       Length = int.Parse(t.Element("Length").Value),
                       Name = t.Element("Name").Value,
                       Path = t.Element("Path").Value,
                       Uploaded = bool.Parse(t.Element("Uploaded").Value)
                   };
        }

        //public static IEnumerable<Track> GetAvailableTracks()
        //{
        //    List<Track> availableTracks = new List<Track>();
        //    IEnumerable<Album> albums = GetAllAlbums();
        //    foreach (Track track in GetAllTracks())
        //    {
        //        bool available = true;
        //        foreach (Album album in albums)
        //        {
        //            if (album.Track.Contains(track))
        //            {
        //                available = false;
        //                break;
        //            }
        //        }
        //        if (available)
        //        {
        //            availableSongs.Add(track);
        //        }
        //    }
        //    return availableSongs;
        //}

    //    public static void DeleteObject(Artist artist)
    //    {
    //        foreach (Instrument instrument in context.Instrument)
    //        {
    //            if (instrument.Artist.Contains(artist))
    //            {
    //                instrument.Artist.Remove(artist);
    //            }
    //        }

    //        foreach (Band band in context.Band)
    //        {
    //            if (band.Artist.Contains(artist))
    //            {
    //                band.Artist.Remove(artist);
    //            }
    //        }

    //        context.Artist.DeleteObject(artist);
    //        SaveChanges();
    //    }

    //    public static void StoreObject(Artist artist)
    //    {
    //        context.Artist.AddObject(artist);
    //        SaveChanges();
    //    }

    //    public static IEnumerable<Artist> GetAllArtists()
    //    {
    //        return context.Artist;
    //    }

    //    public static void DeleteObject(Album album)
    //    {
    //        List<int> tracks = new List<int>();
    //        foreach (Track track in album.Track)
    //        {
    //            tracks.Add(track.Id);
    //        }

    //        context.Album.DeleteObject(album);
    //        SaveChanges();

    //        foreach (Track track in context.Track.Where(t => tracks.Contains(t.Id)))
    //        {
    //            DeleteObject(track);
    //        }
    //        SaveChanges();
    //    }

    //    public static void StoreObject(Album album)
    //    {
    //        context.Album.AddObject(album);
    //        SaveChanges();
    //    }

    //    public static IEnumerable<Album> GetAllAlbums( )
    //    {
    //        return context.Album;
    //    }

    //    public static void DeleteObject(Band band)
    //    {
    //        foreach (Artist artist in context.Artist)
    //        {
    //            if (artist.Band.Contains(band))
    //            {
    //                artist.Band.Remove(band);
    //            }
    //        }

    //        foreach (Concert concert in context.Concert)
    //        {
    //            if (concert.Band.Contains(band))
    //            {
    //                concert.Band.Remove(band);
    //            }
    //        }

    //        List<int> albums = new List<int>();

    //        foreach (Album album in band.Album)
    //        {
    //            albums.Add(album.Id);
    //        }

    //        context.Band.DeleteObject(band);
    //        SaveChanges();

    //        foreach (Album album in context.Album.Where(a => albums.Contains(a.Id)))
    //        {
    //            DeleteObject(album);
    //        }
    //        SaveChanges();
    //    }

    //    public static void StoreObject(Band band)
    //    {
    //        context.Band.AddObject(band);
    //        SaveChanges();
    //    }

    //    public static IEnumerable<Band> GetAllBands( )
    //    {
    //        return context.Band;
    //    }

    //    public static IEnumerable<Band> GetAdjectiveBands(IEnumerable<Band> bands)
    //    {
    //        List<Band> adjectiveBands = new List<Band>();
    //        adjectiveBands.AddRange(GetAllBands());
    //        foreach (Band band in bands)
    //        {
    //            adjectiveBands.Remove(band);
    //        }
    //        return adjectiveBands;
    //    }

        public static void DeleteObject(Instrument instrument)
        {
            foreach (XElement item in db.Descendants("ArtistInstrument").Where(ai => int.Parse(ai.Element("InstrumentID").Value) == instrument.ID))
            {
                item.Remove();
            }

            DeleteElement(GetElement(instrument.ID, "Instrument"));
        }

        public static void StoreObject(Instrument instrument)
        {
            if (instrument.ID != 0)
            {
                GetElement(instrument.ID, "Instrument").Remove();
            }
            else
            {
                instrument.ID = GetElementID("Instrument");
            }

            XElement xinstruments = db.Descendants("Instruments").First();

            xinstruments.Add(instrument.toXML());
        }

        public static IEnumerable<Instrument> GetAllInstruments()
        {
            return from i in db.Descendants("Instrument")
                   select new Instrument()
                   {
                       ID = int.Parse(i.Element("ID").Value),
                       Name = i.Element("Name").Value
                   };
        }

        public static void DeleteObject(Country country)
        {
            foreach (XElement item in db.Descendants("Location").Where(l => int.Parse(l.Element("CountryID").Value) == country.ID))
            {
                item.Remove();
            }

            DeleteElement(GetElement(country.ID, "Country"));
        }

        public static void StoreObject(Country country)
        {
            if (country.ID != 0)
            {
                XElement xCountry = GetElement(country.ID, "Country");

                xCountry.Remove();
            }
            else
            {
                country.ID = GetElementID("Country");
            }

            XElement xCountries = db.Descendants("Countries").First();

            xCountries.Add(country.toXML());
        }

        public static IEnumerable<Country> GetAllCountries()
        {
            IEnumerable<Country> countries = from c in db.Descendants("Country")
                                             select new Country()
                                             {
                                                 ID = int.Parse(c.Element("ID").Value),
                                                 Name = c.Element("Name").Value
                                             };
            return countries;
        }

        public static void StoreObject(Album album) {
            if (album.ID != 0)
                GetElement(album.ID, "Album").Remove();
            else
                album.ID = GetElementID("Album");

            XElement XAlbums = db.Descendants("Album").First();
            XAlbums.Add(album.toXML());       
        }

        public static void DeleteObject(Album album) {
            foreach (XElement item in db.Descendants("Track").Where(a => int.Parse(a.Element("AlbumID").Value) == album.ID)) {
                item.Remove();
            }
            DeleteElement(GetElement(album.ID, "Album"));
        }

        public static IEnumerable<Track> GetTracksByAlbum(Album album)
        {
            return (IEnumerable<Track>) db.Descendants("Track").Where(t => int.Parse(t.Element("AlbumID").Value) == album.ID);
        }

        public static IEnumerable<Album> GetAllAlbums()
        {
            return db.Descendants("Album").Select(a => new Album() {
                ID = int.Parse(a.Element("ID").Value),
                Name = a.Element("Name").Value,
                Band = new Band()
                           {
                               ID = int.Parse(db.Descendants("Bands").Where(b => b.Element("ID").Value == a.Element("BandID").Value).First().Element("ID").Value),
                               Name = db.Descendants("Bands").Where(b => b.Element("ID").Value == a.Element("BandID").Value).First().Element("Name").Value
                           }
            });
        }
        public static void StoreObject(Band band) {
            if (band.ID != 0)
                GetElement(band.ID, "Band").Remove();
            else
                band.ID = GetElementID("Band");

            XElement XAlbums = db.Descendants("Band").First();
            XAlbums.Add(band.toXML());
        }

        public static IEnumerable<Band> GetAllBands() {
            return db.Descendants("Band").Select(a => new Band() {
                ID = int.Parse(a.Element("ID").Value),
                Name = a.Element("Name").Value
            });
        }
    }
}
