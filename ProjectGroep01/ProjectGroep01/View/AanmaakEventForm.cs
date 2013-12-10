using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.People;
using ProjectGroep01.Data.Evenementen;
using ProjectGroep01.Data.Databank;

namespace ProjectGroep01.View
{
    public partial class AanmaakEventForm : Form
    {
        public AanmaakEventForm()
        {
            InitializeComponent();
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            if (Controle())
            {
                string naam = txtBoxEventNaam.Text;
                DateTime datum = dtpDatum.Value.Date;
                string straat = txtBoxStraatNaam.Text;
                int huisnummer = int.Parse(txtBoxHuisnummer.Text);
                string stad = txtBoxStad.Text;
                int aantalPlaatsen = int.Parse(txtBoxAantalPlaatsen.Text);
                int aantalInschrijvingen = 0;
                ITEvent ite = new ITEvent(naam, datum, new Plaats(straat, huisnummer, stad), aantalInschrijvingen, aantalPlaatsen);
                ITEvents.EventsInstantion.Add(ite);
                Databank.DatabankInstantie.AddEvent(ite);
                MessageBox.Show("Uw event is toegevoegd, u kunt zich nu inschrijven","Event aanmaken");
                Close();
            }
        }
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Controle()
        {
            bool ok = ControleerString(txtBoxEventNaam) & ControleerString(txtBoxStraatNaam) & ControleerInteger(txtBoxHuisnummer)
                & ControleerString(txtBoxStad) & ControleerInteger(txtBoxAantalPlaatsen);
            return ok;
        }
        private bool ControleerString(TextBox t)
        {
            if (t.Text == "")
            {
                errorProvider.SetError(t, "Het ingegeven veld mag niet leeg zijn");
                return false;
            }
            else
            {
                errorProvider.SetError(t, "");
                return true;
            }
        }
        private bool ControleerInteger(TextBox t)
        {
            try
            {
                if (int.Parse(t.Text) < 0)
                {
                    errorProvider.SetError(t, "Het ingegeven veld moet positief zijn");
                    return false;
                }
                else
                {
                    errorProvider.SetError(t, "");
                    return true;
                }
            }
            catch
            {
                errorProvider.SetError(t, "Het ingegeven veld moet een positief getal zijn");
                return false;
            }
        }
    }
}
