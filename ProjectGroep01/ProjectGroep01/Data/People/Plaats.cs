using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Data.People
{
    public class Plaats
    {
        private string straatnaam;
        private int huisNummer;
        private string stad;

        public string Straatnaam
        {
            get { return straatnaam; }
            set { straatnaam = value; }
        }

        public int HuisNummer
        {
            get { return huisNummer; }
            set { huisNummer = value; }
        }

        public string Stad 
        {
            get { return stad; }
            set { stad = value; } 
        }

        public Plaats(string straatnaam, int huisnummer, string stad)
        {
            Straatnaam = straatnaam;
            HuisNummer = huisnummer;
            Stad = stad;
        }
    }
}
