using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Concert.DBObjectDefinition
{
    public class Song
    {
        private string id;
        private string trackPath;
        private string name;
        private int length;

        public string ID { get { return id; } }

        public string TrackPath { get { return trackPath; } }

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

        public Song(string name, int length, bool trackUploaded, string path)
        {
            id = name + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
            trackPath = "";
            if (trackUploaded && File.Exists(path))
            {
                trackPath = @"Resources\Audio\" + id + ".mp3";
                File.Copy(path, @"..\..\" + trackPath);
            }
            Name = name;
            Length = length;
        }

        public override string ToString()
        {
            return name + " - " + length + "sec";
        }
    }
}
