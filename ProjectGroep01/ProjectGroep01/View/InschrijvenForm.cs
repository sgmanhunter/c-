using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.Evenementen;
using ProjectGroep01.Data.People;
using ProjectGroep01.Data.Databank;

namespace ProjectGroep01.View
{
    public partial class InschrijvenForm : Form
    {
        private int lidnummer;

        public InschrijvenForm(int lidnummer)
        {
            InitializeComponent();
            InitCheckListBoxInschrijven();
            this.lidnummer = lidnummer;
        }

        private void InitCheckListBoxInschrijven()
        {
            chklstbxInschrijven.Items.Clear();
            for (int i = 0; i < ITEvents.EventsInstantion.Count; i++)
                if (ITEvents.EventsInstantion[i].AantalInschrijvingen < ITEvents.EventsInstantion[i].AantalPlaatsen
                    && ITEvents.EventsInstantion[i].Datum >= DateTime.Today && !Users.UsersInstantion[lidnummer].Events.Contains(ITEvents.EventsInstantion[i]))
                    chklstbxInschrijven.Items.Add(ITEvents.EventsInstantion[i].EventNaam);
        }

        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            int index=0;
            for (int i = 0; i < chklstbxInschrijven.CheckedItems.Count; i++)
            {
                for (int j = 0; j < ITEvents.EventsInstantion.Count; j++)
                    if (chklstbxInschrijven.CheckedItems[i].ToString() == ITEvents.EventsInstantion[j].EventNaam)
                        index = j;
                Users.UsersInstantion[lidnummer - 1].Events.Add(ITEvents.EventsInstantion[index]);
                Databank.DatabankInstantie.AddUserAndEvent(Users.UsersInstantion[lidnummer - 1], ITEvents.EventsInstantion[index]);
                ITEvents.EventsInstantion[index].AantalInschrijvingen++;
            }
            MessageBox.Show("Inschrijven gelukt!", "Inschrijven");
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
