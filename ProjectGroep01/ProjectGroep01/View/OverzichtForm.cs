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
namespace ProjectGroep01.View
{
    public partial class OverzichtForm : Form, IObserver
    {
        private Data.ToonLijst toonLijst;

        public OverzichtForm(Data.ToonLijst t)
        {
            ITEvents.EventsInstantion.NotifyObservers += Updating;
            InitializeComponent();
            toonLijst = t;

            ToonLijst();
        }

        private void ToonLijst()
        {
            List<ITEvent> ite = new List<ITEvent>();
            if (toonLijst != Data.ToonLijst.eigenEvents)
                for (int i = 0; i < ITEvents.EventsInstantion.Count; i++)
                    switch (toonLijst)
                    {
                        case Data.ToonLijst.volzetteEvents:
                            if (ITEvents.EventsInstantion[i].AantalInschrijvingen == ITEvents.EventsInstantion[i].AantalPlaatsen)
                                ite.Add(ITEvents.EventsInstantion[i]);
                            break;
                        case Data.ToonLijst.vrijeEvents:
                            if (ITEvents.EventsInstantion[i].AantalInschrijvingen < ITEvents.EventsInstantion[i].AantalPlaatsen)
                                ite.Add(ITEvents.EventsInstantion[i]);
                            break;
                        case Data.ToonLijst.voorbijeEvents:
                            if (ITEvents.EventsInstantion[i].Datum < DateTime.Now)
                                ite.Add(ITEvents.EventsInstantion[i]);
                            break;
                    }
            txtBoxEvent.Text = "";
            for (int j = 0; j < ite.Count; j++)
                txtBoxEvent.Text += ite[j].ToString() +System.Environment.NewLine;
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
