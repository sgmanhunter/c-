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
using ProjectGroep01.Controller;


namespace ProjectGroep01.View
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            ControllerMain.ControllerInstantion.GrpBoxPicker(grpBoxLoggedIn,grpBoxLogin);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterFrame rf = new RegisterFrame();
            rf.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ControllerMain.ControllerInstantion.ClickLogin(txtBoxUserName, txtBoxPassword, errorProvider, grpBoxLoggedIn, grpBoxLogin);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ControllerMain.ControllerInstantion.IsLoggedIn = false;
            ControllerMain.ControllerInstantion.Userid = 0;
            ControllerMain.ControllerInstantion.GrpBoxPicker(grpBoxLoggedIn, grpBoxLogin);
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
                InscribeEventForm ief = new InscribeEventForm(ControllerMain.ControllerInstantion.Userid);
                ief.ShowDialog();
            }
            else
            {
                WriteOutEventForm uef = new WriteOutEventForm(ControllerMain.ControllerInstantion.Userid);
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
                of = new SummaryForm(Data.ShowList.ownEvents, ControllerMain.ControllerInstantion.Userid);
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
