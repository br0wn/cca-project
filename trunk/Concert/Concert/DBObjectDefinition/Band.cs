using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Concert.DBObjectDefinition
{
    public class Band
    {
        private int id;
        private string name;
        private List<Album> albums;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Album> Albums
        {
            get { return albums; }
            set { albums = value; }
        }

        public XElement toXml()
        {
            XElement band = new XElement("Album",
                new XElement("ID",ID),
                new XElement("Name", Name)                
                );
            foreach (Album album in Albums)
            {
                band.Add(album.toXML());
            }
            return band;
        }
    }
}
