using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Concert
    {
        private int      id;
        private int      ticketPrice;
        private string   name;
        private DateTime date;

        public int ID          { get { return id;          } set { id = value;          } }
        public int TicketPrice { get { return ticketPrice; } set { ticketPrice = value; } }
        public string Name     { get { return name;        } set { name = value;        } }
        public DateTime Date   { get { return date;        } set { date = value;        } }
    }
}
