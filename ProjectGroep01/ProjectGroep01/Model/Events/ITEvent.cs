using ProjectGroep01.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGroep01.Model.Events
{
    public class ITEvent
    {
        #region datamembers
        private int eventNumber;
        private string eventName;
        private DateTime date;
        private int numberOfInscribers, numberOfPlaces;

        private Place place;
        #endregion 

        #region properties
        public int EventNumber
        {
            get { return eventNumber; }
            private set { eventNumber = value; }
        }
        public string EventName
        {
            get { return eventName; }
            private set { eventName = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Place Place
        {
            get { return place; }
            set { place = value; }
        }
        public int NumberOfInscribers
        {
            get { return numberOfInscribers; }
            set 
            {
                numberOfInscribers = value; 
            }
        }
        public int NumberOfPlaces
        {
            get { return numberOfPlaces; }
            private set { numberOfPlaces = value; }
        }
        #endregion 

        #region constructors
        public ITEvent(string eventName, DateTime date, Place place, int numberOfPlaces)
        {
            EventNumber = ITEvents.EventInstantion.CalculateNewEventNumber();
            EventName = eventName;
            Date = date;
            Place = place;
            NumberOfInscribers = 0;
            NumberOfPlaces = numberOfPlaces;
        }
        #endregion 

        #region overrides

        public override string ToString()
        {
            string r = "";
            r = string.Format("Nummer: {0} - Eventnaam: {1} - Adres: {2} {3} {4} - Datum {5} - Aantal inschrijvingen/Aantal plaatsen: {6}/{7}", 
                EventNumber, EventName, Place.Streetname, Place.Housenumber, Place.City, Date.ToShortDateString(), NumberOfInscribers, NumberOfPlaces);
            return  r;
        }

        #endregion
    }
}
