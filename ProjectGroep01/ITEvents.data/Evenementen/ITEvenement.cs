using ITEvents.data.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITEvents.data.Evenementen
{
    public class ITEvenement
    {
        #region datamembers
        private int eventNummer;
        private string eventNaam;        
        private int aantalInschrijvingen, aantalPlaatsen;

        private Plaats plaats;
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
       
        public Plaats Plaats
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
        public ITEvenement(string eventNaam, Plaats plaats, int aantalInschrijvingen, int aantalPlaatsen)
        {
            EventNummer = ITEvenementen.EvenementenInstantie.BerekenNieuwEventNummer();
            Plaats = plaats;
            AantalInschrijvingen = aantalInschrijvingen;
            AantalPlaatsen = aantalPlaatsen;
        }
        public ITEvenement(string eventNaam, Plaats plaats)
            : this(eventNaam, plaats, 0, 30)
        {
        }
        public ITEvenement(string eventNaam, Plaats plaats, int aantalPlaatsen)
            : this(eventNaam, plaats, 0, aantalPlaatsen)
        {
        }
        #endregion 
    }
}
