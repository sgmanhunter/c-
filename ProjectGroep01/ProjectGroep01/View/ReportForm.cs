using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.Databank;
using ProjectGroep01.Data.Databank.CSGroep01DataSetTableAdapters;

namespace ProjectGroep01.View
{
    public partial class ReportForm : Form, IObserver
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            FillReport();
        }

        private void FillReport()
        {
            // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.cSGroep01DataSet.events);

            this.reportViewer1.RefreshReport();
        }

        public void Updating()
        {
            FillReport();
        }
    }
}
