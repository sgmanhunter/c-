using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEvents.data.People
{
    public class Plaats
    {
        private string straatnaam;
        private string huisNummer;
        private string stad;

        public string Straatnaam
        {
            get { return straatnaam; }
            set { straatnaam = value; }
        }

        public string HuisNummer
        {
            get { return huisNummer; }
            set { huisNummer = value; }
        }

        public string Stad 
        {
            get { return stad; }
            set { stad = value; } 
        }
    }
}
