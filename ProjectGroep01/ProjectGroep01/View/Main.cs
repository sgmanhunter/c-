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


namespace ProjectGroep01.View
{
    public partial class Main : Form
    {
        private bool isLoggedIn;
        private int userid;

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }
        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public Main()
        {
            InitializeComponent();
            IsLoggedIn = false;
            Userid = 0;
            GrpBoxPicker();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterFrame rf = new RegisterFrame();
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
            txtBoxUserName.Text = "";
            txtBoxPassword.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text.ToLower();
            string password = txtBoxPassword.Text;
            bool ok = false;
            int index=1;
            for (int i = 0; i < Users.UserInstantion.Count; i++)
            {
                if (Users.UserInstantion[i].Username == username)
                {
                    ok = true;
                    index = i;
                    errorProvider.SetError(txtBoxUserName, "");
                    break;
                }
                else
                    errorProvider.SetError(txtBoxUserName, "Gebruikersnaam bestaat niet");
            }
            if (ok && Users.UserInstantion[index].Password == password)
            {
                IsLoggedIn = true;
                errorProvider.SetError(txtBoxPassword, "");
                Userid = Users.UserInstantion[index].Userid;
            }
            else
                errorProvider.SetError(txtBoxPassword, "Uw wachtwoord klopt niet");
            GrpBoxPicker();
            Reset();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsLoggedIn = false;
            Userid = 0;
            GrpBoxPicker();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rdbtnMakeEvent.Checked)
            {
                MakeEventForm avf = new MakeEventForm();
                avf.ShowDialog();
            }
            else if (rdbtnInscribeEvent.Checked)
            {
                InscribeEventForm ief = new InscribeEventForm(Userid);
                ief.ShowDialog();
            }
            else
            {
                WriteOutEventForm uef = new WriteOutEventForm(Userid);
                uef.ShowDialog();
            }
        }
        private void btnSummary_Click(object sender, EventArgs e)
        {
            SummaryForm of;
            if (rdbtnSummaryEventFree.Checked)
            {
                of = new SummaryForm(Data.ShowList.freeEvents);
                of.Show();
            }
            if (rdbtnSummaryEventFull.Checked)
            {
                of = new SummaryForm(Data.ShowList.fullEvents);
                of.Show();
            }
            if (rdbtnSummaryHistory.Checked)
            {
                of = new SummaryForm(Data.ShowList.passedEvents);
                of.Show();
            }
        }
        private void btnOwnEvent_Click(object sender, EventArgs e)
        {
            SummaryForm of;
            if (rdbtnSummaryOwnEvents.Checked)
            {
                of = new SummaryForm(Data.ShowList.ownEvents, Userid);
                of.Show();
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (rdbtnReportEventFree.Checked)
            {
                ReportForm rf = new ReportForm();
                rf.Show();
            }
        }
    }
}
