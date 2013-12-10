﻿using System;
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
                chklstbxInschrijven.Items.Add(ITEvents.EventsInstantion[i].EventNaam);
        }

        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstbxInschrijven.CheckedIndices.Count; i++)
            {
                if (ITEvents.EventsInstantion[chklstbxInschrijven.CheckedIndices[i]].AantalInschrijvingen < ITEvents.EventsInstantion[chklstbxInschrijven.CheckedIndices[i]].AantalPlaatsen)
                {
                    Users.UsersInstantion[lidnummer - 1].Events.Add(ITEvents.EventsInstantion[chklstbxInschrijven.CheckedIndices[i]]);
                    Databank.DatabankInstantie.AddUserAndEvent(Users.UsersInstantion[lidnummer - 1], ITEvents.EventsInstantion[chklstbxInschrijven.CheckedIndices[i]]);
                    ITEvents.EventsInstantion[chklstbxInschrijven.CheckedIndices[i]].AantalInschrijvingen++;
                }
                else
                {
                    MessageBox.Show("Fout, de reeks zit al vol", "Fout");
                }
            }
            MessageBox.Show("Inschrijven voltooid", "Inschrijven");
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
