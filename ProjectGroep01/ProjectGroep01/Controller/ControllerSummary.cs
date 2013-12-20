using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.Database;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Model.People;

namespace ProjectGroep01.Controller
{
    class ControllerSummary
    {
        private static ControllerSummary controllerInstantion = new ControllerSummary();
        private Data.ShowList showList;
        private int userId;

        

        public static ControllerSummary ControllerInstantion
        {
            get { return controllerInstantion; }
            set { controllerInstantion = value; }
        }
        public Data.ShowList ShowListProperty
        {
            get { return showList; }
            set { showList = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public void ShowList(TextBox tevent)
        {
            List<ITEvent> ite = new List<ITEvent>();
            string title = "Eigen Evenementen";
            if (showList != Data.ShowList.ownEvents)
                for (int i = 0; i < ITEvents.EventInstantion.Count; i++)
                    switch (showList)
                    {
                        case Data.ShowList.fullEvents:
                            title = "Volzette Evenementen";
                            if (ITEvents.EventInstantion[i].NumberOfInscribers == ITEvents.EventInstantion[i].NumberOfPlaces)
                                ite.Add(ITEvents.EventInstantion[i]);
                            break;
                        case Data.ShowList.freeEvents:
                            title = "Vrije Evenementen";
                            if (ITEvents.EventInstantion[i].NumberOfInscribers < ITEvents.EventInstantion[i].NumberOfPlaces && ITEvents.EventInstantion[i].Date >= DateTime.Today)
                                ite.Add(ITEvents.EventInstantion[i]);
                            break;
                        case Data.ShowList.passedEvents:
                            title = "Voorbije Evenementen";
                            if (ITEvents.EventInstantion[i].Date < DateTime.Today)
                                ite.Add(ITEvents.EventInstantion[i]);
                            break;
                    }
            else
                for (int i = 0; i < Users.UserInstantion[userId - 1].Events.Count; i++)
                    ite = Users.UserInstantion[userId - 1].Events;
            tevent.Text = title;
            for (int j = 0; j < ite.Count; j++)
                tevent.Text += System.Environment.NewLine + ite[j];
        }
    }
}
