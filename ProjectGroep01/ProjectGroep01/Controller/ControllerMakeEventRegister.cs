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
    class ControllerMakeEventRegister
    {
        private static ControllerMakeEventRegister controllerInstantion = new ControllerMakeEventRegister();

        public static ControllerMakeEventRegister ControllerInstantion
        {
            get { return controllerInstantion; }
            set { controllerInstantion = value; }
        }
        private ControllerMakeEventRegister()
        {
        }

        private bool ControlString(TextBox t, ErrorProvider errorProvider)
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
        private bool ControlInteger(TextBox t, ErrorProvider errorProvider)
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
        private bool ControlUsername(TextBox txtBoxUsername, ErrorProvider errorProvider)
        {
            bool ok = false;
            for (int i = 0; i < Users.UserInstantion.Count; i++)
                if (txtBoxUsername.Text == Users.UserInstantion[i].Username)
                    errorProvider.SetError(txtBoxUsername, "Gebruikersnaam bestaat al");
                else
                {
                    ok = true;
                    errorProvider.SetError(txtBoxUsername, "");
                }
            return ok;
        }
        private bool ControlPassword(TextBox txtBoxPassword, TextBox txtBoxConfirmPassword, ErrorProvider errorProvider)
        {
            if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                errorProvider.SetError(txtBoxConfirmPassword, "Wachtwoorden komen niet overeen");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxConfirmPassword, "");
                return true;
            }
        }

        private bool ControlInputMake(ErrorProvider errorProvider, TextBox txtBoxEventName, TextBox txtBoxStreetname,
                TextBox txtBoxHousenumber, TextBox txtBoxCity, TextBox txtBoxNumberOfPlaces)
        {
            bool ok = ControlString(txtBoxEventName, errorProvider) &
                ControlString(txtBoxStreetname, errorProvider) &
                ControlInteger(txtBoxHousenumber, errorProvider) &
                ControlString(txtBoxCity, errorProvider) &
                ControlInteger(txtBoxNumberOfPlaces, errorProvider);
            return ok;
        }
        private bool ControlInputRegister(TextBox txtBoxFirstname, TextBox txtBoxLastname,
            TextBox txtBoxUsername, TextBox txtBoxPassword, TextBox txtBoxConfirmPassword, TextBox txtBoxEmail, ErrorProvider errorProvider)
        {
            bool ok = ControlString(txtBoxFirstname, errorProvider) & ControlString(txtBoxLastname, errorProvider) & ControlString(txtBoxUsername, errorProvider)
                & ControlString(txtBoxPassword, errorProvider) & ControlString(txtBoxEmail, errorProvider) & ControlPassword(txtBoxPassword, txtBoxConfirmPassword, errorProvider) & ControlUsername(txtBoxUsername, errorProvider);
            return ok;
        }

        public void ClickMakeEvent(TextBox txtBoxEventName, DateTimePicker dtpDate, TextBox txtBoxStreetname, 
            TextBox txtBoxHousenumber, TextBox txtBoxCity, TextBox txtBoxNumberOfPlaces, ErrorProvider errorProvider)
        {
            if (ControlInputMake(errorProvider, txtBoxEventName, txtBoxStreetname,
                txtBoxHousenumber, txtBoxCity, txtBoxNumberOfPlaces))
            {
                string name = txtBoxEventName.Text;
                DateTime date = dtpDate.Value.Date;
                string street = txtBoxStreetname.Text;
                int housenumber = int.Parse(txtBoxHousenumber.Text);
                string city = txtBoxCity.Text;
                int numberOfPlaces = int.Parse(txtBoxNumberOfPlaces.Text);
                ITEvent ite = new ITEvent(name, date, new Place(street, housenumber, city), numberOfPlaces);
                ITEvents.EventInstantion.Add(ite);
                Database.DatabankInstantion.AddEvent(ite);
                MessageBox.Show("Uw evenement is toegevoegd, u kunt zich nu inschrijven of nog een evenement aanmaken", "Evenement aanmaken");
                ResetMakeForm(txtBoxEventName, txtBoxStreetname, txtBoxHousenumber, txtBoxCity, txtBoxNumberOfPlaces);
            }
        }
        public void ClickRegister(TextBox txtBoxFirstname, DateTimePicker dtpDateOfBirth, TextBox txtBoxLastname,
            TextBox txtBoxUsername, TextBox txtBoxPassword, TextBox txtBoxConfirmPassword, 
            TextBox txtBoxEmail, RadioButton rdbtnMale, ErrorProvider errorProvider)
        {
            if (ControlInputRegister(txtBoxFirstname, txtBoxLastname,
            txtBoxUsername, txtBoxPassword, txtBoxConfirmPassword, txtBoxEmail, errorProvider))
            {
                string firstName = txtBoxFirstname.Text;
                string lastname = txtBoxLastname.Text;
                string username = txtBoxUsername.Text.ToLower();
                string password = txtBoxPassword.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value.Date;
                string email = txtBoxEmail.Text;
                bool sex = rdbtnMale.Checked;
                User user = new User(firstName, lastname, username, password, dateOfBirth, sex, email);
                Users.UserInstantion.Add(user);
                Database.DatabankInstantion.AddUser(user);
                MessageBox.Show("Uw registratie is gelukt! U kunt zich aanmelden of nog iemand registreren", "Registreren");
                ResetRegisterForm(txtBoxFirstname, txtBoxLastname, txtBoxUsername, txtBoxPassword, txtBoxConfirmPassword, txtBoxEmail);
            }
        }

        private void ResetMakeForm(TextBox txtBoxEventName, TextBox txtBoxStreetname, 
            TextBox txtBoxHousenumber, TextBox txtBoxCity, TextBox txtBoxNumberOfPlaces)
        {
            txtBoxEventName.Text = "";
            txtBoxStreetname.Text = "";
            txtBoxEventName.Text = "";
            txtBoxHousenumber.Text = "";
            txtBoxCity.Text = "";
            txtBoxNumberOfPlaces.Text = "";
        }
        private void ResetRegisterForm(TextBox txtBoxFirstname, TextBox txtBoxLastname,
            TextBox txtBoxUsername, TextBox txtBoxPassword, TextBox txtBoxConfirmPassword,
            TextBox txtBoxEmail)
        {
            txtBoxFirstname.Text = "";
            txtBoxLastname.Text = "";
            txtBoxUsername.Text = "";
            txtBoxPassword.Text = "";
            txtBoxConfirmPassword.Text = "";
            txtBoxEmail.Text = "";
        }
    }
}
