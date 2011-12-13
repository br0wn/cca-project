using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    public class Album
    {
        public int ID { get; set; }
        public Band Band { get; set; }
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }

        public XElement toXML()
        {
            XElement album = new XElement("Album",
                                                    new XElement("ID", ID),
                                                    new XElement("Name", Name),
                                                    new XElement("BandID", Band.ID)                                                    
                                                    );                 
            return album;            
       }
    }
}
