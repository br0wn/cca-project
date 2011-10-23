using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    public class Concert
    {
        private string id;
        private string name;
        private int ticketPrice;
        private DateTime date;
        private Location geoLocation;
        private List<Band> bands;

        public string ID { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public int TicketPrice { get { return ticketPrice; } set { ticketPrice = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public Location GeoLocation { get { return geoLocation; } set { geoLocation = value; } }
        public List<Band> Bands { get { return bands; } }

        public Concert(string name, int ticketPrice, DateTime date)
        {
            Name = name;
            TicketPrice = ticketPrice;
            Date = date;
            bands = new List<Band>();
        }

        public Concert(string name, int ticketPrice, DateTime date, Location location, List<Band> bands)
        {
            id = name + DateTime.Now.ToString();
            Name = name;
            TicketPrice = ticketPrice;
            Date = date;
            GeoLocation = location;
            this.bands = bands;
        }

        public void AddBand(Band band)
        {
            this.bands.Add(band);
        }

        public override string ToString()
        {
            StringBuilder concertInfo = new StringBuilder("Concert name : " + name + "\r\nTicket price : " + ticketPrice + "\r\n");
            concertInfo.Append(GeoLocation);
            foreach (Band band in bands)
            {
                concertInfo.Append("\r\n\tBands :\r\n" + band.ToString());
            }
            return concertInfo.ToString();
        }
    }
}
