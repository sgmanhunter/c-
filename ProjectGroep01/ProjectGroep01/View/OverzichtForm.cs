using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.Evenementen;
using ProjectGroep01.Data.People;
namespace ProjectGroep01.View
{
    public partial class OverzichtForm : Form, IObserver
    {
        private Data.ToonLijst toonLijst;
        private int lidnummer;
        public OverzichtForm(Data.ToonLijst t)
        {
            ITEvents.EventsInstantion.NotifyObservers += Updating;
            InitializeComponent();
            toonLijst = t;

            ToonLijst();
        }

        public OverzichtForm(Data.ToonLijst t, int lidnummer)
        {
            ITEvents.EventsInstantion.NotifyObservers += Updating;
            InitializeComponent();
            this.lidnummer = lidnummer;
            toonLijst = t;

            ToonLijst();
        }

        private void ToonLijst()
        {
            List<ITEvent> ite = new List<ITEvent>();
            string title = "Eigen Evenementen";
            if (toonLijst != Data.ToonLijst.eigenEvents)
                for (int i = 0; i < ITEvents.EventsInstantion.Count; i++)
                    switch (toonLijst)
                    {
                        case Data.ToonLijst.volzetteEvents:
                            title = "Volzette Evenementen";
                            if (ITEvents.EventsInstantion[i].AantalInschrijvingen == ITEvents.EventsInstantion[i].AantalPlaatsen)
                                ite.Add(ITEvents.EventsInstantion[i]);
                            break;
                        case Data.ToonLijst.vrijeEvents:
                            title = "Vrije Evenementen";
                            if (ITEvents.EventsInstantion[i].AantalInschrijvingen < ITEvents.EventsInstantion[i].AantalPlaatsen)
                                ite.Add(ITEvents.EventsInstantion[i]);
                            break;
                        case Data.ToonLijst.voorbijeEvents:
                            title = "Voorbije Evenementen";
                            if (ITEvents.EventsInstantion[i].Datum < DateTime.Today)
                                ite.Add(ITEvents.EventsInstantion[i]);
                            break;
                    }
            else
                for (int i = 0; i < Users.UsersInstantion[lidnummer-1].Events.Count; i++)
                    ite = Users.UsersInstantion[lidnummer-1].Events;
            txtBoxEvent.Text = title;
            for (int j = 0; j < ite.Count; j++)
                txtBoxEvent.Text += System.Environment.NewLine + ite[j];
        }

        public void Updating()
        {
            ToonLijst();
        }

        private void OverzichtForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ITEvents.EventsInstantion.NotifyObservers -= Updating;
        }
    }
}
