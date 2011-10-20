using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o.Config;

using Concert.DBObjectDefinition;

namespace Concert.DataAccessLayer
{
    class DBObjectController
    {
        public readonly static string YapFileName = "../../db4o reference/concerts.yap";
            //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "concerts.yap");

        public static IObjectContainer db;

        public static IEmbeddedConfiguration config;

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

        public static IEnumerable<Location> GetAllLocations()
        {
            return db.Query<Location>(l => true);
        }

        public static IEnumerable<Song> GetAllTracks()
        {
            return db.Query<Song>(s => true);
        }

		public static IEnumerable<Artist> GetAllArtists()
		{
			return db.Query<Artist>( a => true );
		}

		public static IEnumerable<Album> GetAllAlbums( )
		{
			return db.Query<Album>( a => true );
		}

        public static IEnumerable<Album> GetAlbumsByTrack(Song track)
        {
            return db.Query<Album>(a => a.Songs.Contains(track)); 
        }

		public static IEnumerable<Band> GetAllBands( )
		{
			return db.Query<Band>( b => true );
		}

         public static IEnumerable<Band> GetBandsByArtist(Artist artist)
        {
            return db.Query<Band>(b => b.Artist.Contains(artist));
        }
    }
}
