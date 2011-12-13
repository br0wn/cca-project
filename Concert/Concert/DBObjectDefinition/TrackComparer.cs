using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class TrackComparer : IEqualityComparer<Track>
    {
        public bool Equals(Track x, Track y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(Track obj)
        {
            return obj.ID.GetHashCode();
        }
    }
}
