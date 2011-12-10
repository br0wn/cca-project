using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    public class Country
    {
        private int    id;
        private string name;

        public int ID      { get { return id;   } set { id = value;   } }
        public string Name { get { return name; } set { name = value; } }

        public XElement toXML()
        {
            return new XElement("Country",
                                            new XElement("ID", ID),
                                            new XElement("Name", Name));
        }
    }
}
