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
using ProjectGroep01.Data.Database;

namespace ProjectGroep01.View
{
    public partial class RegisterFrame : Form
    {
        public RegisterFrame()
        {
            InitializeComponent();
            rdbtnMale.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ControlInput())
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
                MessageBox.Show("Uw registratie is gelukt! U kunt zich aanmelden of nog iemand registreren","Registreren");
                Close();
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ControlInput()
        {
            bool ok = ControlString(txtBoxFirstname) & ControlString(txtBoxLastname) & ControlString(txtBoxUsername)
                & ControlString(txtBoxPassword) & ControlString(txtBoxEmail) & ControlPassword() & ControlUsername();
            return ok;
        }

        private bool ControlString(TextBox t)
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
        private bool ControlPassword()
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

        private bool ControlUsername()
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
    }
}
