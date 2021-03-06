﻿using System;
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
using ProjectGroep01.Data;


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
                InscribeEventForm ief = new InscribeEventForm(ControllerMain.ControllerInstantion.Userid-1);
                ief.ShowDialog();
            }
            else
            {
                WriteOutEventForm uef = new WriteOutEventForm(ControllerMain.ControllerInstantion.Userid-1);
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
            else
            {
                ReportForm rf = new ReportForm(ShowReport.ownEvents, ControllerMain.ControllerInstantion.Userid);
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm rf;
            if (rdbtnReportEventFree.Checked)
                rf = new ReportForm(ShowReport.freeEvents);
            else
                rf = new ReportForm(ShowReport.statistics);
            rf.Show();
        }
    }
}
