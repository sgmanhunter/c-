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
            ITEvenementen.EvenementInstantie.NotifyObservers += Updating;
            InitializeComponent();
            toonLijst = t;

            ToonLijst();
        }

        private void ToonLijst()
        {
            List<ITEvenement> ite = new List<ITEvenement>();
            if (toonLijst != Data.ToonLijst.eigenEvents)
                for (int i = 0; i < ITEvenementen.EvenementInstantie.Count; i++)
                    switch (toonLijst)
                    {
                        case Data.ToonLijst.volzetteEvents:
                            if (ITEvenementen.EvenementInstantie[i].AantalInschrijvingen == ITEvenementen.EvenementInstantie[i].AantalPlaatsen)
                                ite.Add(ITEvenementen.EvenementInstantie[i]);
                            break;
                        case Data.ToonLijst.vrijeEvents:
                            if (ITEvenementen.EvenementInstantie[i].AantalInschrijvingen < ITEvenementen.EvenementInstantie[i].AantalPlaatsen)
                                ite.Add(ITEvenementen.EvenementInstantie[i]);
                            break;
                        case Data.ToonLijst.voorbijeEvents:
                            if (ITEvenementen.EvenementInstantie[i].Datum < DateTime.Now)
                                ite.Add(ITEvenementen.EvenementInstantie[i]);
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
            ITEvenementen.EvenementInstantie.NotifyObservers -= Updating;
        }
    }
}
