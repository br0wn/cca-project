using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    class Location
    {
        private int    id;
        private int    countryID;
        private int    seatCount;
        private int    postalCode;
        private string address;

        public int ID         { get { return id;         } set { id = value;         } }
        public int CountryID  { get { return countryID;  } set { countryID = value;  } }
        public int SeatCount  { get { return seatCount;  } set { seatCount = value;  } }
        public int PostalCode { get { return postalCode; } set { postalCode = value; } }
        public string Address { get { return address;    } set { address = value;    } }

        public XElement toXML()
        {
            return new XElement("Location",
                                            new XElement("ID", ID),
                                            new XElement("CountryID", CountryID),
                                            new XElement("SeatCount", SeatCount),
                                            new XElement("PostalCode", PostalCode),
                                            new XElement("Address", Address));
        }
    }
}
