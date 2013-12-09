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
        private usersTableAdapter uta;
        private signupTableAdapter sta;
        private eventsTableAdapter eta;

        public static Databank DatabankInstantie
        {
            get { return databankInstantie; }
        }

        private Databank()
        {
            csGroep01DataSet = new CSGroep01DataSet();
            uta = new usersTableAdapter();
            sta = new signupTableAdapter();
            eta = new eventsTableAdapter();
        }

        public void ReadUsers()
        {
            uta.Fill(csGroep01DataSet.users);
            for (int i = 0; i < csGroep01DataSet.users.Rows.Count; i++)
            {
                User user = new User(csGroep01DataSet.users[i].firstname,csGroep01DataSet.users[i].lastname,
                    csGroep01DataSet.users[i].username,csGroep01DataSet.users[i].password,
                    DateTime.Parse(csGroep01DataSet.users[i].birthday),csGroep01DataSet.users[i].male,csGroep01DataSet.users[i].email);
                Users.UsersInstantion.Add(user);
            }
        }

        public void ReadEvents()
        {
            eta.Fill(csGroep01DataSet.events);
            for (int i = 0; i < csGroep01DataSet.events.Rows.Count; i++)
            {
                ITEvent ite = new ITEvent(csGroep01DataSet.events[i].eventname, 
                    new Plaats("", 0, csGroep01DataSet.events[i].location), 
                    csGroep01DataSet.events[i].maxparticipants);
                ITEvents.EventsInstantion.Add(ite);
            }
        }

        public void ReadUsersAndEvents(int lidnr)
        {
            
        }
    }
}
