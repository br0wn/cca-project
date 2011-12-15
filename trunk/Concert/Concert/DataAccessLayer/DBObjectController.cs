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

        public static XDocument db;
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

        public static void DeleteObject(DBObjectDefinition.Concert concert)
        {
            db.Descendants("ConcertBand")
              .Where(cb => int.Parse(cb.Element("ConcertID").Value) == concert.ID).Remove();

            DeleteElement(GetElement(concert.ID, "Concert"));
        }

        public static void StoreObject(DBObjectDefinition.Concert concert)
        {
            if (concert.ID != 0)
                GetElement(concert.ID, "Concert").Remove();
            else
                concert.ID = GetElementID("Concert");

            XElement xConcerts = db.Descendants("Concerts").First();

            xConcerts.Add(concert.toXML());

            db.Descendants("ConcertBand").Where(cb => int.Parse(cb.Element("ConcertID").Value) == concert.ID).Remove();

            XElement xConcertsBands = db.Descendants("ConcertsBands").First();

            foreach (Band band in concert.Bands)
            {
                xConcertsBands.Add(new XElement("ConcertBand",
                                                                new XElement("ConcertID", concert.ID),
                                                                new XElement("BandID", band.ID)));
            }
        }

        public static IEnumerable<DBObjectDefinition.Concert> GetAllConcerts()
        {
            return from c in db.Descendants("Concert")
                   where int.Parse(c.Element("ID").Value) != 0
                   select new DBObjectDefinition.Concert()
                   {
                       ID = int.Parse(c.Element("ID").Value),
                       Name = c.Element("Name").Value,
                       TicketPrice = int.Parse(c.Element("TicketPrice").Value),
                       Date = DateTime.Parse(c.Element("Date").Value),
                       GeoLocation = db.Descendants("Location")
                                       .Where(l => int.Parse(l.Element("ID").Value) != 0 &&
                                                   int.Parse(l.Element("ID").Value) == int.Parse(c.Element("LocationID").Value))
                                       .Select(l => new Location()
                                       {
                                           ID = int.Parse(l.Element("ID").Value),
                                           PostalCode = int.Parse(l.Element("PostalCode").Value),
                                           SeatCount = int.Parse(l.Element("SeatCount").Value),
                                           Address = l.Element("ID").Value,
                                           Country = db.Descendants("Country")
                                                       .Where(d => int.Parse(d.Element("ID").Value) == int.Parse(l.Element("CountryID").Value))
                                                       .Select(d => new Country()
                                                       {
                                                           Name = d.Element("Name").Value
                                                       })
                                                       .First()
                                       })
                                       .First(),
                        Bands = GetAllBands().Where(b => db.Descendants("ConcertBand")
                                                         .Where(cb => int.Parse(cb.Element("ConcertID").Value) == int.Parse(c.Element("ID").Value))
                                                         .Select( cb => int.Parse(cb.Element("BandID").Value))
                                                         .Contains(b.ID)).ToList()
                   };
        }

        public static IEnumerable<DBObjectDefinition.Concert> GetCustomConcerts(string name, int fromPrice, int toPrice, DateTime fromDate, DateTime toDate)
        {
            if (!string.IsNullOrEmpty(name))
            {
               return GetAllConcerts().Where(c => c.Name.ToLower().Contains(name.ToLower()) &&
                                                  c.TicketPrice >= fromPrice &&
                                                  c.TicketPrice <= toPrice &&
                                                  c.Date >= fromDate &&
                                                  c.Date <= toDate);
            }
            else
            {
                return GetAllConcerts().Where(c => c.TicketPrice >= fromPrice &&
                                                   c.TicketPrice <= toPrice &&
                                                   c.Date >= fromDate &&
                                                   c.Date <= toDate);
            }
        }

        public static void DeleteObject(Location location)
        {
            IEnumerable<DBObjectDefinition.Concert> concerts = GetAllConcerts().Where(c => c.GeoLocation != null &&
                                                                                           c.GeoLocation.ID != location.ID);

            foreach (DBObjectDefinition.Concert concert in concerts)
            {
                concert.GeoLocation = null;
                StoreObject(concert);
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
                   where int.Parse(l.Element("ID").Value) != 0
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
                   where int.Parse(t.Element("ID").Value) != 0 
                   select new Track() 
                   {
                       ID = int.Parse(t.Element("ID").Value),
                       Length = int.Parse(t.Element("Length").Value),
                       Name = t.Element("Name").Value,
                       Path = t.Element("Path").Value,
                       Uploaded = bool.Parse(t.Element("Uploaded").Value)
                   };
        }

        public static IEnumerable<Track> GetAvailableTracks()
        {
            return from t in db.Descendants("Track")
                   where int.Parse(t.Element("ID").Value) != 0 && int.Parse(t.Element("AlbumID").Value) == 0
                   select new Track()
                   {
                       ID       = int.Parse(t.Element("ID").Value),
                       Length   = int.Parse(t.Element("Length").Value),
                       Name     = t.Element("Name").Value,
                       Path     = t.Element("Path").Value,
                       Uploaded = bool.Parse(t.Element("Uploaded").Value)
                   };
         }

        public static IEnumerable<Band> GetAdjectiveBands(IEnumerable<Band> bands)
        {
            return GetAllBands().Except(bands);
        }

        public static void DeleteObject(Instrument instrument)
        {
            db.Descendants("ArtistInstrument").Where(ai => int.Parse(ai.Element("InstrumentID").Value) == instrument.ID).Remove();

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
                   where int.Parse(i.Element("ID").Value) != 0
                   select new Instrument()
                   {
                       ID = int.Parse(i.Element("ID").Value),
                       Name = i.Element("Name").Value
                   };
        }

        public static void DeleteObject(Country country)
        {
            IEnumerable<Location> locations =  db.Descendants("Location").Where(l => int.Parse(l.Element("CountryID").Value) == country.ID)
                                                 .Select(l => new Location()
                                                 {
                                                     ID = int.Parse(l.Element("ID").Value)
                                                 });
            foreach (Location location in locations)
	        {
                DeleteObject(location);
	        }

            DeleteElement(GetElement(country.ID, "Country"));
        }

        public static void StoreObject(Country country)
        {
            if (country.ID != 0)
            {
                GetElement(country.ID, "Country").Remove();
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
                                             where int.Parse(c.Element("ID").Value) != 0
                                             select new Country()
                                             {
                                                 ID = int.Parse(c.Element("ID").Value),
                                                 Name = c.Element("Name").Value
                                             };
            return countries;
        }

        public static void StoreObject(Album album)
        {
            if (album.ID != 0)
                GetElement(album.ID, "Album").Remove();
            else
                album.ID = GetElementID("Album");

            XElement XAlbums = db.Descendants("Albums").First();
            XAlbums.Add(album.toXML());

            IEnumerable<int> trackIDs = from t in album.Tracks
                                        select t.ID;

            List<Track> tracks = (List<Track>) (from t in db.Descendants("Track")
                                         where int.Parse(t.Element("AlbumID").Value) == album.ID// &&
                                         //trackIDs.Contains(int.Parse(t.Element("AlbumID").Value))
                                         select new Track()
                                                    {
                                                        ID = int.Parse(t.Element("ID").Value),
                                                        Length = int.Parse(t.Element("Length").Value),
                                                        Name = t.Element("Name").Value,
                                                        Path = t.Element("Path").Value,
                                                        Uploaded = bool.Parse(t.Element("Uploaded").Value)
                                                    }).ToList();

            foreach (Track track in tracks)
            {
                track.Album = null;
                StoreObject(track);
            }

            foreach (Track track in album.Tracks)
            {
                track.Album = album;
                StoreObject(track);
            }
        }

        public static void DeleteObject(Album album) 
        {
            db.Descendants("Track").Where(t => int.Parse(t.Element("AlbumID").Value) == album.ID).Remove();

            DeleteElement(GetElement(album.ID, "Album"));
        }

        public static List<Track> GetTracksByAlbum(int albumID)
        {
            IEnumerable<Track> tracks = from t in db.Descendants("Track")
                                        where int.Parse(t.Element("AlbumID").Value) == albumID
                                        select new Track()
                                        {
                                            ID = int.Parse(t.Element("ID").Value),
                                            Length = int.Parse(t.Element("Length").Value),
                                            Name = t.Element("Name").Value,
                                            Path = t.Element("Path").Value,
                                            Uploaded = bool.Parse(t.Element("Uploaded").Value)
                                        };
            return tracks.ToList();
        }

        public static IEnumerable<Album> GetAllAlbums()
        {
            IEnumerable<Album> allAlbums =  from a in db.Descendants("Album")
                                                  where int.Parse(a.Element("ID").Value) != 0
                                                  select new Album
                                                             {
                                                                 ID = int.Parse(a.Element("ID").Value),
                                                                 Name = a.Element("Name").Value,
                                                                 Band = int.Parse(a.Element("BandID").Value) == 0
                                                                            ? null
                                                                            : new Band
                                                                                  {
                                                                                      ID =
                                                                                          int.Parse(
                                                                                              a.Element("BandID").Value),
                                                                                      Name =
                                                                                          db.Descendants("Band").Where(
                                                                                              b =>
                                                                                              int.Parse(
                                                                                                  b.Element("ID").Value) ==
                                                                                              int.Parse(
                                                                                                  a.Element("BandID").
                                                                                                      Value))
                                                                                          .First()
                                                                                          .Element("Name").Value
                                                                                  },
                                                                 Tracks =
                                                                     (List<Track>) (from t in db.Descendants("Track")
                                                                                    where
                                                                                        int.Parse(
                                                                                            t.Element("AlbumID").Value) ==
                                                                                        int.Parse(a.Element("ID").Value)
                                                                                    select new Track
                                                                                               {
                                                                                                   ID =
                                                                                                       int.Parse(
                                                                                                           t.Element(
                                                                                                               "ID").
                                                                                                               Value),
                                                                                                   Name =
                                                                                                       t.Element("Name")
                                                                                                       .Value,
                                                                                                   Path =
                                                                                                       t.Element("Name")
                                                                                                       .Value,
                                                                                                   Length =
                                                                                                       int.Parse(
                                                                                                           t.Element(
                                                                                                               "Length")
                                                                                                               .Value),
                                                                                                   Uploaded = false,
                                                                                                   Album = null
                                                                                               }).ToList()
                                                             };    
            return allAlbums.ToList();
        }

        public static void StoreObject(Band band)
        {
            if (band.ID != 0)
            {
                GetElement(band.ID, "Band").Remove();
            }
            else
            {
                band.ID = GetElementID("Band");
            }

            XElement XBands = db.Descendants("Bands").First();
			XBands.Add( band.toXML( ) );

			// osvjezi veze sa izvodjacima
			db.Descendants( "BandArtist" ).Where( dba => int.Parse( dba.Element( "BandID" ).Value ) == band.ID ).Remove( );
            foreach (Artist artist in band.Artists)
            {
                XElement xBandsArtists = db.Descendants("BandsArtists").First();
                XElement bandArtist = 
					new XElement("BandArtist",
						new XElement("BandID", band.ID),
						new XElement("ArtistID", artist.ID)
					);

                xBandsArtists.Add(bandArtist);
            }

			// osvjezi veze sa albumima, tj. pobrisi one albume koji su prije bili vezani za bend a sad vise nisu
			//List<Album> albums = GetAllAlbums( ).Where( a => a.Band.ID == band.ID ).ToList( );
			//foreach ( Album album in albums.ToList( ) )
			//{
			//    if ( !band.Albums.Contains( album ) )
			//    {
			//        DeleteObject( album );
			//    }
			//}
        }

		public static void DeleteObject( Band band )
		{
			foreach ( Album album in band.Albums )
			{
				DeleteObject( album );
			}

			db.Descendants( "BandArtist" ).Where( ba => int.Parse( ba.Element( "BandID" ).Value ) == band.ID ).Remove( );
			db.Descendants( "ConcertBand" ).Where( cb => int.Parse( cb.Element( "BandID" ).Value ) == band.ID ).Remove( );
			db.Descendants( "Band" ).Where( b => int.Parse( b.Element( "ID" ).Value ) == band.ID ).Remove( );
		}

        public static IEnumerable<Band> GetAllBands() 
        {
            var bands = db.Descendants("Band").Where( b => int.Parse(b.Element("ID").Value) != 0)
                                         .Select(a => new Band() 
            {
                ID = int.Parse(a.Element("ID").Value),
                Name = a.Element("Name").Value,
				Artists = GetArtistByBand( int.Parse( a.Element( "ID" ).Value ) ).ToList(),
				Albums =  
					(from b in db.Descendants( "Album" )
					where int.Parse( b.Element( "BandID" ).Value ) == int.Parse( a.Element( "ID" ).Value )
					select new Album( )
					{
						ID = int.Parse(b.Element("ID").Value),
						Name = b.Element("Name").Value,
						Tracks =		(from t in db.Descendants("Track")
									where int.Parse(t.Element("AlbumID").Value) == int.Parse(b.Element("ID").Value)
									select new Track() 
									{
										ID = int.Parse(t.Element("ID").Value),
										Name = t.Element("Name").Value,
										Path = t.Element("Name").Value,
										Length = int.Parse(t.Element("Length").Value)
									}).ToList()      
					}).ToList()
            });

			foreach ( Band band in bands )
			{
				foreach ( Album album in band.Albums )
				{
					album.Band = band;
				}
			}

			return bands;
        }

        #region ArtistFunctions

		public static IEnumerable<Artist> GetArtistByBand( int bandID )
		{
			var artistsIDs = from a in db.Descendants( "BandArtist" )
							 where int.Parse( a.Element( "BandID" ).Value ) == bandID
						  select int.Parse( a.Element( "ArtistID" ).Value );

			return from c in db.Descendants( "Artist" )
				   where artistsIDs.Contains( int.Parse( c.Element( "ID" ).Value ) )
				   select new Artist( )
				   {
					   // skopirano iz GetAllArtists
					   ID = int.Parse( c.Element( "ID" ).Value ),
					   FirstName = c.Element( "FirstName" ).Value,
					   LastName = c.Element( "LastName" ).Value,
					   BirthDate = Convert.ToDateTime( c.Element( "BirthDate" ).Value ),
					   Instruments = new List<Instrument>
					   (
							from ai in db.Descendants( "ArtistInstrument" )
							where ai.Element( "ArtistID" ).Value == c.Element( "ID" ).Value
							select new Instrument( )
							{
								ID = int.Parse( ai.Element( "InstrumentID" ).Value ),
								Name = db.Descendants( "Instrument" ).Where( i => i.Element( "ID" ).Value == ai.Element( "InstrumentID" ).Value ).First( ).Element( "Name" ).Value
							}
						)
				   };
		}

        public static void StoreObject(Artist artist)
        {
            if (artist.ID != 0)
            {
                GetElement(artist.ID, "Artist").Remove();
            }
            else
            {
                artist.ID = GetElementID("Artist");
            }

            XElement xArtists = db.Descendants("Artists").First();

            xArtists.Add(artist.toXML());

            db.Descendants("ArtistInstrument").Where(ai => int.Parse(ai.Element("ArtistID").Value) == artist.ID).Remove();

            foreach (Instrument i in artist.Instruments)
            {
                XElement xArtistsInstruments = db.Descendants("ArtistsInstruments").First();

                XElement artistInstrument = new XElement("ArtistInstrument",
                                                    new XElement("ArtistID", artist.ID),
                                                    new XElement("InstrumentID", i.ID));

                xArtistsInstruments.Add(artistInstrument);
            }
        }

        public static IEnumerable<Artist> GetAllArtists()
        {
            IEnumerable<Artist> artists = from c in db.Descendants("Artist")
										  where int.Parse( c.Element( "ID" ).Value ) != 0
                                          select new Artist()
                                           {
                                               ID = int.Parse(c.Element("ID").Value),
                                               FirstName = c.Element("FirstName").Value,
                                               LastName = c.Element("LastName").Value,
                                               BirthDate = Convert.ToDateTime(c.Element("BirthDate").Value),
                                               Instruments = new List<Instrument>
                                               (
                                                    from ai in db.Descendants("ArtistInstrument")
                                                    where ai.Element("ArtistID").Value == c.Element("ID").Value                                               
                                                    select new Instrument()
                                                    {
                                                        ID = int.Parse(ai.Element("InstrumentID").Value),
                                                        Name = db.Descendants("Instrument").Where( i => i.Element("ID").Value  == ai.Element("InstrumentID").Value).First().Element("Name").Value
                                                    }
                                                )
                                           };

            return artists;
        }

        public static void DeleteObject(Artist artist)
        {
            db.Descendants("ArtistInstrument").Where(ai => int.Parse(ai.Element("ArtistID").Value) == artist.ID).Remove();

            db.Descendants("BandArtist").Where(ba => int.Parse(ba.Element("ArtistID").Value) == artist.ID).Remove();

            DeleteElement(GetElement(artist.ID, "Artist"));
        } 
        #endregion


    }
}
