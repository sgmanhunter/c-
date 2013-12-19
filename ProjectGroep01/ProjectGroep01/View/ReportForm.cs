using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.Database;
using ProjectGroep01.Data.Database.CSGroep01DataSetTableAdapters;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Model.People;

namespace ProjectGroep01.View
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.cSGroep01DataSet.events);

            this.rpvFreeEvents.RefreshReport();
        }

        //private void ReportForm_Load(object sender, EventArgs e)
        //{
        //   this.reportViewer1.RefreshReport();
        //}

        //private void FillReport()
        //{
        //    // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
        //    this.eventsTableAdapter.Fill(this.cSGroep01DataSet.events);
        //}

        //private void FillOwnEventsReport()
        //{
        //    // TODO: This line of code loads data into the 'cSGroep01DataSet.events' table. You can move, or remove it, as needed.
        //    CSGroep01DataSet.eventsDataTable temp;
        //    temp = this.cSGroep01DataSet.events;
        //    temp.Rows[1].Delete();

        //    for (int i = 0; i < Users.UsersInstantion[1].Events.Count; i++)
        //    {
        //        CSGroep01DataSet.eventsRow eventsrow = temp.NeweventsRow();
        //        Databank.DatabankInstantie.FillEventRow(eventsrow, Users.UsersInstantion[0].Events[i]);
        //        int id = Users.UsersInstantion[0].Events[i].EventNummer;
        //        string name = Users.UsersInstantion[0].Events[i].EventNaam;
        //        DateTime date = Users.UsersInstantion[0].Events[i].Datum;
        //        string streetname = Users.UsersInstantion[0].Events[i].Plaats.Straatnaam;
        //        string location = Users.UsersInstantion[0].Events[i].Plaats.Stad;
        //        int housenumber = Users.UsersInstantion[0].Events[i].Plaats.HuisNummer;
        //        int maxparticipants = Users.UsersInstantion[0].Events[i].AantalPlaatsen;
        //        temp.Rows.Add(eventsrow);
        //    }
        //    //this.eventsTableAdapter.Update(temp);
        //    this.eventsTableAdapter.Fill(temp);
        //}

        //public void Updating()
        //{
        //    FillReport();
        //}
    }
}
