using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    class Track
    {
        private int    id;
        private int    length;
        //private int albumID;
        private bool   uploaded;
        private string name;
        private string path;

        public int ID        { get { return id;       } set { id = value;       } }
        public int Length    { get { return length;   } set { length = value;   } }
        //public int AlbumID   { get { return albumID;  } set { albumID = value;  } }
        public bool Uploaded { get { return uploaded; } set { uploaded = value; } }
        public string Name   { get { return name;     } set { name = value;     } }
        public string Path   { get { return path;     } set { path = value;     } }

        public XElement toXML()
        {
            return new XElement("Track",
                                            new XElement("ID", ID),
                                            new XElement("Length", Length),
                                            //new XElement("AlbumID", AlbumID),
                                            new XElement("Uploaded", Uploaded),
                                            new XElement("Name", Name),
                                            new XElement("Path", path));
        }
    }
}
