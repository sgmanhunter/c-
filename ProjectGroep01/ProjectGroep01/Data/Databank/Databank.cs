using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ProjectGroep01.Data.Databank.CSGroep01DataSetTableAdapters;
using ProjectGroep01.Data.People;
using ProjectGroep01.Data.Evenementen;

namespace ProjectGroep01.Data.Databank
{
    class Databank
    {
        private static Databank databankInstantie = new Databank();
        private CSGroep01DataSet csGroep01DataSet;
        private userTableAdapter uta;
        private signupTableAdapter sta;
        private eventsTableAdapter eta;

        public static Databank DatabankInstantie
        {
            get { return databankInstantie; }
        }

        private Databank()
        {
            csGroep01DataSet = new CSGroep01DataSet();
            uta = new userTableAdapter();
            sta = new signupTableAdapter();
            eta = new eventsTableAdapter();
        }

        public void ReadUsers()
        {
            uta.Fill(csGroep01DataSet.user);
            for (int i = 0; i < csGroep01DataSet.user.Rows.Count; i++)
            {
                User user = new User(csGroep01DataSet.user[i].firstname,csGroep01DataSet.user[i].lastname,
                    csGroep01DataSet.user[i].username,csGroep01DataSet.user[i].password,
                    csGroep01DataSet.user[i].birthday,csGroep01DataSet.user[i].male,csGroep01DataSet.user[i].email);
                Users.UsersInstantion.Add(user);
            }
        }

        public void ReadEvents()
        {
            eta.Fill(csGroep01DataSet.events);
            for (int i = 0; i < csGroep01DataSet.events.Rows.Count; i++)
            {
                ITEvent ite = new ITEvent(csGroep01DataSet.events[i].eventname, csGroep01DataSet.events[i].eventdate,
                    new Plaats("", csGroep01DataSet.events[i].housenumber, csGroep01DataSet.events[i].location), 
                    csGroep01DataSet.events[i].maxparticipants);
                ITEvents.EventsInstantion.Add(ite);
            }
        }

        public void ReadUsersAndEvents()
        {
            sta.Fill(csGroep01DataSet.signup);
            for (int i = 0; i < csGroep01DataSet.signup.Rows.Count; i++)
            {
                Users.UsersInstantion[(csGroep01DataSet.signup[i].userid) - 1].Events.Add(ITEvents.EventsInstantion[(csGroep01DataSet.signup[i].eventid) - 1]);
                ITEvents.EventsInstantion[(csGroep01DataSet.signup[i].eventid) - 1].AantalInschrijvingen++;
            }
        }

        private void FillUserRow(CSGroep01DataSet.userRow userRow, User user)
        {
            userRow.userid = user.Lidnr;
            userRow.firstname = user.Voornaam;
            userRow.lastname = user.Familienaam;
            userRow.username = user.Gebruikersnaam;
            userRow.password = user.Wachtwoord;
            userRow.birthday = user.Geboortedatum;
            userRow.email = user.Email;
            userRow.male = user.Man;
        }

        private void FillEventRow(CSGroep01DataSet.eventsRow eventsRow, ITEvent ite)
        {
            eventsRow.eventid = ite.EventNummer;
            eventsRow.eventname = ite.EventNaam;
            eventsRow.eventdate = ite.Datum;
            eventsRow.location = ite.Plaats.Stad;
            eventsRow.housenumber = ite.Plaats.HuisNummer;
            //eventsRow.streetname = ite.Plaats.Straatnaam;
            eventsRow.maxparticipants = ite.AantalPlaatsen;
        }

        public void AddUser(User user)
        {
            CSGroep01DataSet.userRow userRow = csGroep01DataSet.user.NewuserRow();
            FillUserRow(userRow, user);
            csGroep01DataSet.user.Rows.Add(userRow);

            uta.Update(csGroep01DataSet.user);
        }

        public void AddEvent(ITEvent ite)
        {
            CSGroep01DataSet.eventsRow eventsRow = csGroep01DataSet.events.NeweventsRow();
            FillEventRow(eventsRow, ite);
            csGroep01DataSet.events.Rows.Add(eventsRow);

            eta.Update(csGroep01DataSet.events);
        }
    }
}
