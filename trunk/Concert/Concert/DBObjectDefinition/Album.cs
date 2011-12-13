using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    public class Album
    {
        private int id;
        private Band band;
        private string name;        

        public int ID             { get { return id;     } set { id = value;      } }
        public Band Band { get { return band; } set { band = value; } }
        public string Name        { get { return name;   } set { name = value;    } }

        public XElement toXML()
        {
            XElement album = new XElement("Album",
                                                    new XElement("ID", ID),
                                                    new XElement("BandID", band.ID),                                                    
                                                    new XElement("Name", Name));                 
            return album;
        }
    }
}
