using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ProjectGroep01.Data.Database.CSGroep01DataSetTableAdapters;
using ProjectGroep01.Model.People;
using ProjectGroep01.Model.Events;

namespace ProjectGroep01.Data.Database
{
    class Database
    {
        private static Database databankInstantion = new Database();
        private CSGroep01DataSet csGroep01DataSet;
        private userTableAdapter uta;
        private signupTableAdapter sta;
        private eventsTableAdapter eta;

        public static Database DatabankInstantion
        {
            get { return databankInstantion; }
        }

        private Database()
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
                Users.UserInstantion.Add(user);
            }
        }

        public void ReadEvents()
        {
            eta.Fill(csGroep01DataSet.events);
            for (int i = 0; i < csGroep01DataSet.events.Rows.Count; i++)
            {
                ITEvent ite = new ITEvent(csGroep01DataSet.events[i].eventname, csGroep01DataSet.events[i].eventdate,
                    new Place(csGroep01DataSet.events[i].streetname, csGroep01DataSet.events[i].housenumber, csGroep01DataSet.events[i].location), 
                    csGroep01DataSet.events[i].maxparticipants);
                ITEvents.EventInstantion.Add(ite);
            }
        }

        public void ReadUsersAndEvents()
        {
            sta.Fill(csGroep01DataSet.signup);
            for (int i = 0; i < csGroep01DataSet.signup.Rows.Count; i++)
            {
                Users.UserInstantion[(csGroep01DataSet.signup[i].userid) - 1].Events.Add(ITEvents.EventInstantion[(csGroep01DataSet.signup[i].eventid) - 1]);
                ITEvents.EventInstantion[(csGroep01DataSet.signup[i].eventid) - 1].NumberOfInscribers++;
            }
        }

        private void FillUserRow(CSGroep01DataSet.userRow userRow, User user)
        {
            userRow.userid = user.Userid;
            userRow.firstname = user.Firstname;
            userRow.lastname = user.Lastname;
            userRow.username = user.Username;
            userRow.password = user.Password;
            userRow.birthday = user.DateOfBirth;
            userRow.email = user.Email;
            userRow.male = user.Male;
        }

        public void FillEventRow(CSGroep01DataSet.eventsRow eventsRow, ITEvent ite)
        {
            eventsRow.eventid = ite.EventNumber;
            eventsRow.eventname = ite.EventName;
            eventsRow.eventdate = ite.Date;
            eventsRow.location = ite.Place.City;
            eventsRow.housenumber = ite.Place.Housenumber;
            eventsRow.streetname = ite.Place.Streetname;
            eventsRow.maxparticipants = ite.NumberOfPlaces;
        }

        private void FillUserAndEventRow(CSGroep01DataSet.signupRow signupRow, User user, ITEvent ite)
        {
            signupRow.userid = user.Userid;
            signupRow.eventid = ite.EventNumber;
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

        public void AddUserAndEvent(User user, ITEvent ite)
        {
            CSGroep01DataSet.signupRow signupRow = csGroep01DataSet.signup.NewsignupRow();
            FillUserAndEventRow(signupRow, user, ite);
            csGroep01DataSet.signup.Rows.Add(signupRow);

            sta.Update(csGroep01DataSet.signup);
        }

        public void DeleteUserAndEvent(User user, ITEvent ite)
        {
            sta.DeleteByUserIdAndEventId(user.Userid, ite.EventNumber);

            sta.Update(csGroep01DataSet.signup);
        }
    }
}
