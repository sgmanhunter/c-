using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data;
using ProjectGroep01.Data.Database;
using ProjectGroep01.Data.Database.CSGroep01DataSetTableAdapters;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Model.People;

namespace ProjectGroep01.View
{
    public partial class ReportForm : Form
    {
        private ShowReport report;
        private int userid;
        public ReportForm(ShowReport t, int userid)
        {
            report = t;
            this.userid = userid
            InitializeComponent();
        }
        public ReportForm(ShowReport t)
            : this(t, 0)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
            ShowRightReport();
            this.rpvFreeEvents.RefreshReport();
        }

        private void FillFreeEvents()
        {
            this.eventsTableAdapter.FillByDate(this.cSGroep01DataSet.events, DateTime.Today);
        }

        private void ShowRightReport() 
        { 
            switch(report)
            {
                case ShowReport.freeEvents:
                    FillFreeEvents();
                    break;
                case ShowReport.statistics:
                    FillStatisticsEvents();
                    break;
            }
        }

        private void FillStatisticsEvents()
        {
            this.eventsTableAdapter.Fill(this.cSGroep01DataSet.events);
        }

    }
}
