using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concert.DBObjectDefinition
{
    class Artist
    {
        private string firstname;
        private string lastname;
        private List<string> instruments;
        private DateTime birthDate;

        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public List<string> Instruments { get { return instruments; } set { instruments = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }

        public Artist(string firstname, string lastname, DateTime birthDate)
        {
            Firstname = firstname;
            Lastname = lastname;
            BirthDate = birthDate;
            instruments = new List<string>();
        }
        public void ResetInst()
        {
            instruments.Clear();
        }

        public void AddInst(string inst)
        {
            instruments.Add(inst);
        }

        public override string ToString()
        {
            StringBuilder artistInfo = new StringBuilder(firstname + ", " + lastname + " - " + birthDate + " { ");
            foreach (string item in instruments)
            {
                artistInfo.Append(item + " ");
            }
            artistInfo.Append("}\r\n");
            return artistInfo.ToString();
        }
    }
}
