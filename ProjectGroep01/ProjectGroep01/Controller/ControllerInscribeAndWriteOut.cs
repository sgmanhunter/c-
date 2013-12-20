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
    class ControllerInscribeAndWriteOut
    {
        private static ControllerInscribeAndWriteOut controllerInstantion = new ControllerInscribeAndWriteOut();

        public static ControllerInscribeAndWriteOut ControllerInstantion
        {
            get { return controllerInstantion; }
            set { controllerInstantion = value; }
        }
        public void InitCheckListBoxInscribe(CheckedListBox c, int userid)
        {
            c.Items.Clear();
            for (int i = 0; i < ITEvents.EventInstantion.Count; i++)
                if (ITEvents.EventInstantion[i].NumberOfInscribers < ITEvents.EventInstantion[i].NumberOfPlaces
                    && ITEvents.EventInstantion[i].Date >= DateTime.Today && !Users.UserInstantion[userid].Events.Contains(ITEvents.EventInstantion[i]))
                    c.Items.Add(ITEvents.EventInstantion[i].EventName);
        }
        public void InitCheckListBoxWriteOut(CheckedListBox c, int userid)
        {
            c.Items.Clear();
            for (int i = 0; i < Users.UserInstantion[userid].Events.Count; i++)
                c.Items.Add(Users.UserInstantion[userid].Events[i].EventName);
        }
        public void ClickBtnInscribe(CheckedListBox c, int userid)
        {
            int index = 0;
            for (int i = 0; i < c.CheckedItems.Count; i++)
            {
                for (int j = 0; j < ITEvents.EventInstantion.Count; j++)
                    if (c.CheckedItems[i].ToString() == ITEvents.EventInstantion[j].EventName)
                        index = j;
                Users.UserInstantion[userid].Events.Add(ITEvents.EventInstantion[index]);
                Database.DatabankInstantion.AddUserAndEvent(Users.UserInstantion[userid], ITEvents.EventInstantion[index]);
                ITEvents.EventInstantion[index].NumberOfInscribers++;
            }
            MessageBox.Show("Inschrijven gelukt!", "Inschrijven");
        }

        public void ClickBtnWriteOut(CheckedListBox c, int userid)
        {
            for (int i = 0; i < c.CheckedIndices.Count; i++)
            {
                int index = ITEvents.EventInstantion.IndexOf(Users.UserInstantion[userid].Events[c.CheckedIndices[i]]);
                Users.UserInstantion[userid].Events.RemoveAt(c.CheckedIndices[i]);
                ITEvents.EventInstantion[c.CheckedIndices[i]].NumberOfInscribers--;
                Database.DatabankInstantion.DeleteUserAndEvent(Users.UserInstantion[userid], ITEvents.EventInstantion[index]);
            }
            MessageBox.Show("Uitschrijven voltooid", "Uitschrijven");
        }
    }
}
