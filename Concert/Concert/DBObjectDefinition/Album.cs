using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    class Album
    {
        private int         id;
        private int         bandID;
        private string      name;
        private List<Track> tracks;

        public int ID             { get { return id;     } set { id = value;      } }
        public int BandID         { get { return bandID; } set { bandID = value;  } }
        public string Name        { get { return name;   } set { name = value;    } }
        public List<Track> Tracks { get { return tracks; } set { tracks = value;  } }

        public XElement toXML()
        {
            XElement album = new XElement("Album",
                                                    new XElement("ID", ID),
                                                    new XElement("BandID", bandID),
                                                    new XElement("Name", Name));
            
            foreach (Track track in tracks)
	        {
		        album.Add(track.toXML());
	        }

            return album;
        }
    }
}
