using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Album
    {
        private int         id;
        private string      name;
        private int         bandID;
        private List<Track> tracks;

        public int ID      { get { return id;   } set { id = value;   } }
        public string Name { get { return name; } set { name = value; } }
    }
}
