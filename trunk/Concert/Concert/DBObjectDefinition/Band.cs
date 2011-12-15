using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Concert.DBObjectDefinition
{
    public class Band : IEqualityComparer<Band>
    {
        private int _id;
        private string _name;
        private List<Album> _albums = new List<Album>();
        private List<Artist> _artists = new List<Artist>();

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Album> Albums
        {
            get { return _albums; }
            set { _albums = value; }
        }

        public List<Artist> Artists
        {
            get { return _artists; }
            set { _artists = value; }
        }

        public XElement toXML()
        {
            XElement band = new XElement("Band",
                new XElement("ID",ID),
                new XElement("Name", Name)                
                );      
            return band;
        }

        public bool Equals(Band x, Band y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(Band obj)
        {
            return obj.ID.GetHashCode();
        }
    }
}
