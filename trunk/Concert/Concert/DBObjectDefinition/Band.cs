﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Concert.DBObjectDefinition
{
    public class Band
    {
        private int _id;
        private string _name;
        private List<Album> _albums;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Album> Albums
        {
            get { return _albums; }
            set { _albums = value; }
        }

        public XElement toXML()
        {
            XElement band = new XElement("Band",
                new XElement("ID",ID),
                new XElement("Name", Name)                
                );      
            return band;
        }
    }
}
