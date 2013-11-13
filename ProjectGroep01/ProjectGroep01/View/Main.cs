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
    public partial class Main : Form
    {
        private bool isLoggedIn;

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
        public Main()
        {
            InitializeComponent();
            IsLoggedIn = false;
            GrpBoxPicker();
            
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            RegistreerFrame rf = new RegistreerFrame();
            rf.ShowDialog();
        }

        private void GrpBoxPicker()
        {
            if (isLoggedIn)
            {
                grpBoxLoggedIn.Visible = true;
                grpBoxLogin.Visible = false;
            }
            else
            {
                grpBoxLoggedIn.Visible = false;
                grpBoxLogin.Visible = true;
            }
        }
        private void Reset()
        {
            txtBoxGebruikersnaam.Text = "";
            txtBoxWachtwoord.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = txtBoxGebruikersnaam.Text;
            string wachtwoord = txtBoxWachtwoord.Text;
            bool ok = false;
            int index=1;
            for (int i = 0; i < Leden.LedenInstantie.Count; i++)
            {
                if (Leden.LedenInstantie[i].Gebruikersnaam == gebruikersnaam)
                {
                    ok = true;
                    index = i;
                    errorProvider.SetError(txtBoxGebruikersnaam, "");
                    break;
                }
                else
                    errorProvider.SetError(txtBoxGebruikersnaam, "Gebruikersnaam bestaat niet");
            }
            if (ok && Leden.LedenInstantie[index].Wachtwoord == wachtwoord)
            {
                IsLoggedIn = true;
                errorProvider.SetError(txtBoxWachtwoord, "");
            }
            else
                errorProvider.SetError(txtBoxWachtwoord, "Uw wachtwoord klopt niet");
            GrpBoxPicker();
            Reset();
        }

        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            IsLoggedIn = false;
            GrpBoxPicker();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rdbtnAanmakenEvent.Checked)
            {
                AanmaakEventForm avf = new AanmaakEventForm();
                avf.ShowDialog();
            }
        }
    }
}
