using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Model.People
{
    public class Place
    {
        private string streetname;
        private int housenumber;
        private string city;

        public string Streetname
        {
            get { return streetname; }
            set { streetname = value; }
        }

        public int Housenumber
        {
            get { return housenumber; }
            set { housenumber = value; }
        }

        public string City 
        {
            get { return city; }
            set { city = value; } 
        }

        public Place(string streetname, int housenumber, string city)
        {
            Streetname = streetname;
            Housenumber = housenumber;
            City = city;
        }
    }
}
