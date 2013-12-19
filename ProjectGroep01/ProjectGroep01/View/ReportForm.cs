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
using ProjectGroep01.Data.Evenementen;
using ProjectGroep01.Data.People;

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
            // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
            FillOwnEventsReport();
            this.reportViewer1.RefreshReport();
        }

        private void FillReport()
        {
            // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.cSGroep01DataSet.events);
        }

        private void FillOwnEventsReport()
        {
            // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
            CSGroep01DataSet.eventsDataTable temp = new CSGroep01DataSet.eventsDataTable();
            for (int i = 0; i < Users.UsersInstantion[1].Events.Count; i++)
            {
                int id = Users.UsersInstantion[1].Events[i].EventNummer;
                string name = Users.UsersInstantion[1].Events[i].EventNaam;
                DateTime date = Users.UsersInstantion[1].Events[i].Datum;
                string streetname = Users.UsersInstantion[1].Events[i].Plaats.Straatnaam;
                string location = Users.UsersInstantion[1].Events[i].Plaats.Stad;
                int housenumber = Users.UsersInstantion[1].Events[i].Plaats.HuisNummer;
                int maxparticipants = Users.UsersInstantion[1].Events[i].AantalPlaatsen;
                temp.AddeventsRow(id, name, date, location, housenumber, maxparticipants, streetname);
            }
            this.eventsTableAdapter.Fill(temp);
        }

        public void Updating()
        {
            FillReport();
        }
    }
}
