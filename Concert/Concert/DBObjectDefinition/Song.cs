using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Song
    {
        private string name;
        private int length;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public Song(string name, int length)
        {
            Name = name;
            Length = length;
        }

        public override string ToString()
        {
            return name + " - " + length + "sec";
        }
    }
}
