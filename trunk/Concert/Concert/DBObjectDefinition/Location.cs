using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    public class Location
    {
        private string id;
        private string country;
        private string address;
        private int postalCode;
        private int seatCount;

        public string ID { get { return id; } }
        public string Country { get { return country; } set { country = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int PostalCode { get { return postalCode; } set { postalCode = value; } }
        public int SeatCount { get { return seatCount; } set { seatCount = value; } }

        public Location(string country, string address, int postalCode, int seatCount)
        {
            id = address + DateTime.Now.ToString();
            Country = country;
            Address = address;
            PostalCode = postalCode;
            SeatCount = seatCount;
        }

        public override string ToString()
        {
            StringBuilder locationInfo = new StringBuilder();
            locationInfo.Append("\tCountry     : " + country +
                                "\r\n\tAddress     : " + address +
                                "\r\n\tPostal code : " + postalCode +
                                "\r\n\tSeat count  : #" + seatCount + "\r\n");
            return locationInfo.ToString();
        }
    }
}
