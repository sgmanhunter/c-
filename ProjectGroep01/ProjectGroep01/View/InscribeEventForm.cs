using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Model.People;
using ProjectGroep01.Data.Database;

namespace ProjectGroep01.View
{
    public partial class InscribeEventForm : Form
    {
        private int userid;

        public InscribeEventForm(int userid)
        {
            InitializeComponent();
            InitCheckListBoxInschrijven();
            this.userid = userid;
        }

        private void InitCheckListBoxInschrijven()
        {
            chklstbxInscribe.Items.Clear();
            for (int i = 0; i < ITEvents.EventInstantion.Count; i++)
                if (ITEvents.EventInstantion[i].NumberOfInscribers < ITEvents.EventInstantion[i].NumberOfPlaces
                    && ITEvents.EventInstantion[i].Date >= DateTime.Today && !Users.UserInstantion[userid].Events.Contains(ITEvents.EventInstantion[i]))
                    chklstbxInscribe.Items.Add(ITEvents.EventInstantion[i].EventName);
        }

        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            int index=0;
            for (int i = 0; i < chklstbxInscribe.CheckedItems.Count; i++)
            {
                for (int j = 0; j < ITEvents.EventInstantion.Count; j++)
                    if (chklstbxInscribe.CheckedItems[i].ToString() == ITEvents.EventInstantion[j].EventName)
                        index = j;
                Users.UserInstantion[userid - 1].Events.Add(ITEvents.EventInstantion[index]);
                Database.DatabankInstantion.AddUserAndEvent(Users.UserInstantion[userid - 1], ITEvents.EventInstantion[index]);
                ITEvents.EventInstantion[index].NumberOfInscribers++;
            }
            MessageBox.Show("Inschrijven gelukt!", "Inschrijven");
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
