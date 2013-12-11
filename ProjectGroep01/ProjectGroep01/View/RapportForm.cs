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
    public partial class RapportForm : Form
    {
        public RapportForm()
        {
            InitializeComponent();
        }


        private void RapportForm_Load(object sender, EventArgs e)
        {
            vulRapport(reportViewerEvents, "events");
            this.reportViewerEvents.RefreshReport();
        }

        private void vulRapport(Microsoft.Reporting.WinForms.ReportViewer reportViewer1, string rapportNaam)
        {
            CSGroep01DataSet ds = new CSGroep01DataSet();


            Type t = Type.GetType("ProjectGroep01.Data.Databank.CSGroep01DataSetTableAdapters." + rapportNaam + "TableAdapter");
            Object ta = Activator.CreateInstance(t);
            t.InvokeMember("Fill", System.Reflection.BindingFlags.InvokeMethod, null, ta, new object[] { ds.Tables[rapportNaam] });

            // ReportDataSource aanmaken en initialiseren
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
            rds.Name = "RDS" + rapportNaam;
            rds.Value = ds.Tables[rapportNaam];

            // ReportViewer initialiseren (d.w.z. opvullen met de data)
            // data van het rapport instellen
            reportViewer1.LocalReport.DataSources.Add(rds);

            // ontwerp van het rapport
            reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGroep01.Rapporten." + rapportNaam + ".rdlc";
        }
    }
}
