using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Model.People;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Data.Database;

namespace ProjectGroep01.View
{
    public partial class MakeEventForm : Form
    {
        public MakeEventForm()
        {
            InitializeComponent();
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            if (ControlInput())
            {
                string name = txtBoxEventName.Text;
                DateTime date = dtpDate.Value.Date;
                string street = txtBoxStreetname.Text;
                int housenumber = int.Parse(txtBoxHousenumber.Text);
                string city = txtBoxCity.Text;
                int numberOfPlaces = int.Parse(txtBoxNumberOfPlaces.Text);
                ITEvent ite = new ITEvent(name, date, new Place(street, housenumber, city),numberOfPlaces);
                ITEvents.EventInstantion.Add(ite);
                Database.DatabankInstantion.AddEvent(ite);
                MessageBox.Show("Uw event is toegevoegd, u kunt zich nu inschrijven","Event aanmaken");
                Close();
            }
        }
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ControlInput()
        {
            bool ok = ControleerString(txtBoxEventName) & ControleerString(txtBoxStreetname) & ControleerInteger(txtBoxHousenumber)
                & ControleerString(txtBoxCity) & ControleerInteger(txtBoxNumberOfPlaces);
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
