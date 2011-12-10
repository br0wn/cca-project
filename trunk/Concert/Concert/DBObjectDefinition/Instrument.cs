using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Instrument
    {
        private int    id;
        private string name;

        public int ID      { get { return id;   } set { id = value;   } }
        public string Name { get { return name; } set { name = value; } }

        public XElement toXML()
        {
            return new XElement("Instrument",
                                                new XElement("ID", id),
                                                new XElement("Name", name));
        }
    }
}
