using ProjectGroep01.Data.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGroep01.Data.Evenementen
{
    public class ITEvenement
    {
        #region datamembers
        private int eventNummer;
        private string eventNaam;
        private DateTime datum;
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
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
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
        public ITEvenement(string eventNaam, DateTime datum, Plaats plaats, int aantalInschrijvingen, int aantalPlaatsen)
        {
            EventNummer = ITEvenementen.EvenementInstantie.BerekenNieuwEventNummer();
            EventNaam = eventNaam;
            Datum = datum;
            Plaats = plaats;
            AantalInschrijvingen = aantalInschrijvingen;
            AantalPlaatsen = aantalPlaatsen;
        }
        public ITEvenement(string eventNaam, DateTime datum, Plaats plaats)
            : this(eventNaam, datum, plaats, 0, 30)
        {
        }
        public ITEvenement(string eventNaam, DateTime datum, Plaats plaats, int aantalPlaatsen)
            : this(eventNaam, datum, plaats, 0, aantalPlaatsen)
        {
        }
        #endregion 

        #region overrides

        public override string ToString()
        {
            string r = "";
            r = string.Format("Nummer: {0} - Eventnaam: {1} - Adres: {2} {3} {4} - Datum {5} - Aantal inschrijvingen/Aantal plaatsen: {6}/{7}", 
                EventNummer, EventNaam, Plaats.Straatnaam, Plaats.HuisNummer, Plaats.Stad, Datum.ToShortDateString(), AantalInschrijvingen, AantalPlaatsen);
            return  r;
        }

        #endregion
    }
}
