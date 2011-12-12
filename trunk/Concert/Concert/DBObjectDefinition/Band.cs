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

        public XElement toXml()
        {
            XElement band = new XElement("Album",
                new XElement("ID",ID),
                new XElement("Name", Name)                
                );      
            return band;
        }
    }
}
