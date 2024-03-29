﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Concert.DBObjectDefinition
{
    public class Artist : IComparable<Artist>
    {

        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        //private List<Band> bands;
        private List<Instrument> instruments;

        public int ID { get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        //public List<Band> Bands { get { return bands; } set { bands = value; } }
        public List<Instrument> Instruments { get { return instruments; } set { instruments = value; } }
		public string FullName { get { return FirstName + " " + LastName; } }

        public XElement toXML()
        {
            XElement album = new XElement("Artist",
                                                    new XElement("ID", ID),
                                                    new XElement("FirstName", FirstName),
                                                    new XElement("LastName", LastName),
                                                    new XElement("BirthDate", BirthDate.ToString("dd.MM.yyyy")));
            return album;
        }

        public int CompareTo(Artist a)
        {
            return a.ID.CompareTo(this.ID);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
