using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Model
{
    class Lid
    {
        #region datamembers
        private int lidnr;
        private string voornaam;
        private string familienaam;
        private DateTime geboortedatum;
        private bool man;
        private string email;
        private List<ITEvent> events;
        #endregion

        #region properties
        public int Lidnr
        {       
            get
            {
                return lidnr;
            }
            private set
            {
                lidnr = value;
            }
        }
        public string Voornaam
        {        
            get
            {
                return voornaam;
            }
            private set
            {
                voornaam = value;
            }
        }
        public string Familienaam
        {
            get
            {
                return familienaam;
            }
            private set
            {
                familienaam = value;
            }
        }
        public DateTime Geboortedatum
        {      
            get
            {
                return geboortedatum;
            }
            private set
            {
                geboortedatum = value;
            }
        }
        public bool Man
        {    
            get
            {
                return man;
            }
            private set
            {
                man = value;
            }
        }
        public string Email
        {   
            get
            {
                return email;
            }
            private set
            {
                email = value;
            }
        }
        public List<ITEvent> Events
        {
            get
            {
                return events;
            }
            private set
            {
                events = value;
            }
        }
        #endregion

        #region constructors
        public Lid(string voornaam, string familienaam, DateTime geboortedatum, bool man, string email, List<ITEvent> events)
        {
            Lidnr = Leden.LedenInstantie.BerekenNieuwLidNummer();
            Voornaam = voornaam;
            Familienaam = familienaam;
            Geboortedatum = geboortedatum;
            Man = man;
            Email = email;
            Events = events;
        }
        public Lid(string voornaam, string familienaam, DateTime geboortedatum, bool man, string email)
            : this(voornaam, familienaam, geboortedatum, man, email, new List<ITEvent>())
        {
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return String.Format("{0:d2} - {1} {2}", Lidnr, Familienaam, Voornaam);
        }
        #endregion
    }
}
