using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGroep01.Data.Evenementen;

namespace ProjectGroep01.Data.People
{
    class Lid
    {
        #region datamembers
        private int lidnr;
        private string voornaam;
        private string familienaam;
        private string gebruikersnaam;
        private string wachtwoord;
        private DateTime geboortedatum;
        private bool man;
        private string email;
        private List<ITEvenement> events;
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
        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            private set { gebruikersnaam = value; }
        }
        public string Wachtwoord
        {
            get { return wachtwoord; }
            private set { wachtwoord = value; }
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
        public List<ITEvenement> Events
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
        public Lid(string voornaam, string familienaam, string gebruikersnaam, string wachtwoord, DateTime geboortedatum, bool man, string email, List<ITEvenement> events)
        {
            Lidnr = Leden.LedenInstantie.BerekenNieuwLidNummer();
            Voornaam = voornaam;
            Familienaam = familienaam;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            Geboortedatum = geboortedatum;
            Man = man;
            Email = email;
            Events = events;
        }
        public Lid(string voornaam, string familienaam, string gebruikersnaam, string wachtoord, DateTime geboortedatum, bool man, string email)
            : this(voornaam, familienaam, gebruikersnaam, wachtoord, geboortedatum, man, email, new List<ITEvenement>())
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
