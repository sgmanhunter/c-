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
using ProjectGroep01.Data;

namespace ProjectGroep01.View
{
    public partial class SummaryForm : Form, IObserver
    {
        private Data.ShowList showList;
        private int userId;

        public SummaryForm(Data.ShowList t)
        {
            ITEvents.EventInstantion.NotifyObservers += Updating;
            InitializeComponent();
            showList = t;

            ShowList();
        }
        public SummaryForm(Data.ShowList t, int lidnummer)
        {
            ITEvents.EventInstantion.NotifyObservers += Updating;
            InitializeComponent();
            this.userId = lidnummer;
            showList = t;

            ShowList();
        }

        private void ShowList()
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
                            if (ITEvents.EventInstantion[i].NumberOfInscribers < ITEvents.EventInstantion[i].NumberOfPlaces)
                                ite.Add(ITEvents.EventInstantion[i]);
                            break;
                        case Data.ShowList.passedEvents:
                            title = "Voorbije Evenementen";
                            if (ITEvents.EventInstantion[i].Date < DateTime.Today)
                                ite.Add(ITEvents.EventInstantion[i]);
                            break;
                    }
            else
                for (int i = 0; i < Users.UserInstantion[userId-1].Events.Count; i++)
                    ite = Users.UserInstantion[userId-1].Events;
            txtBoxEvent.Text = title;
            for (int j = 0; j < ite.Count; j++)
                txtBoxEvent.Text += System.Environment.NewLine + ite[j];
        }

        public void Updating()
        {
            ShowList();
        }

        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ITEvents.EventInstantion.NotifyObservers -= Updating;
        }
    }
}
