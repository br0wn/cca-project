using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    class ArtistInstrument
    {
        private int artistID;
        private int instrumentID;

        public int ArtistID { get { return artistID; } set { artistID = value; } }
        public int InstrumentID { get { return instrumentID; } set { instrumentID = value; } }

        public XElement toXML()
        {
            XElement artistInstrument = new XElement("ArtistInstrument",
                                                    new XElement("ArtistID", artistID),
                                                    new XElement("InstrumentID", instrumentID));
            return artistInstrument;
        }
    }
}
