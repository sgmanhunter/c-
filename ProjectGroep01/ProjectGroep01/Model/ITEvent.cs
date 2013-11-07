using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGroep01.Model
{
    class ITEvent
    {
        #region datamembers
        private int eventNummer;
        private string eventNaam;
        private string straatnaam;
        private int huisNummer;
        private string plaats;
        private int aantalInschrijvingen;
        private int aantalPlaatsen;
        #endregion 

        #region properties
        public int EventNummer
        {
            get { return eventNummer; }
            private set { eventNummer = value; }
        }
        public string EventNaam
        {
            get { return eventNaam; }
            private set { eventNaam = value; }
        }
        public string Straatnaam
        {
            get { return straatnaam; }
            private set { straatnaam = value; }
        }
        public int HuisNummer
        {
            get { return huisNummer; }
            private set
            {
                if (value < 1)
                    throw new Exception("Huisnummer moet groter zijn dan 1");
                huisNummer = value;
            }
        }
        public string Plaats
        {
            get { return plaats; }
            set { plaats = value; }
        }
        public int AantalInschrijvingen
        {
            get { return aantalInschrijvingen; }
            set 
            {
                if (value < 0)
                    throw new Exception("AantalInschrijvingen moet minstens 1 zijn");
                aantalInschrijvingen = value; 
            }
        }
        public int AantalPlaatsen
        {
            get { return aantalPlaatsen; }
            private set { aantalPlaatsen = value; }
        }
        #endregion 

        #region constructors
        public ITEvent(string eventNaam, string straatNaam, int huisNummer, string plaats, int aantalInschrijvingen, int aantalPlaatsen)
        {
            EventNummer = ITEvents.EventsInstantie.BerekenNieuwEventNummer();
            Straatnaam = straatnaam;
            HuisNummer = huisNummer;
            Plaats = plaats;
            AantalInschrijvingen = aantalInschrijvingen;
            AantalPlaatsen = aantalPlaatsen;
        }
        public ITEvent(string eventNaam, string straatNaam, int huisNummer, string plaats)
            : this(eventNaam, straatNaam, huisNummer, plaats, 0, 30)
        {
        }
        public ITEvent(string eventNaam, string straatNaam, int huisNummer, string plaats, int aantalPlaatsen)
            : this(eventNaam, straatNaam, huisNummer, plaats, 0, aantalPlaatsen)
        {
        }
        #endregion 
    }
}
