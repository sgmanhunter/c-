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

namespace ProjectGroep01.View
{
    public partial class RegistreerFrame : Form
    {
        public RegistreerFrame()
        {
            InitializeComponent();
            rdbtnMan.Checked = true;
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            if (Controle())
            {
                string voornaam = txtBoxVoornaam.Text;
                string familienaam = txtBoxFamilienaam.Text;
                string gebruikersnaam = txtBoxGebruikersnaam.Text.ToLower();
                string wachtwoord = txtBoxWachtwoord.Text;
                DateTime geboortedatum = dTPgeboortedatum.Value.Date;
                string email = txtBoxEmail.Text;
                bool geslacht = rdbtnMan.Checked;
                User lid = new User(voornaam, familienaam, gebruikersnaam, wachtwoord, geboortedatum, geslacht, email);
                Users.UsersInstantion.Add(lid);
                MessageBox.Show("Uw registratie is gelukt!","Registreren");
                Close();
            }

        }
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Controle()
        {
            bool ok = ControleString(txtBoxVoornaam) & ControleString(txtBoxFamilienaam) & ControleString(txtBoxGebruikersnaam)
                & ControleString(txtBoxWachtwoord) & ControleString(txtBoxEmail) & ControleWachtwoord();
            return ok;
        }

        private bool ControleString(TextBox t)
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
        private bool ControleWachtwoord()
        {
            if (txtBoxWachtwoord.Text != txtBoxWachtwoordBevestig.Text)
            {
                errorProvider.SetError(txtBoxWachtwoordBevestig, "Wachtwoorden komen niet overeen");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxWachtwoordBevestig, "");
                return true;
            }
        }
    }
}
