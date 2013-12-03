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
            for (int i = 0; i < ITEvenementen.EvenementInstantie.Count; i++)
                chklstbxInschrijven.Items.Add(ITEvenementen.EvenementInstantie[i].EventNaam);
        }

        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstbxInschrijven.CheckedIndices.Count; i++)
            {
                Leden.LedenInstantie[lidnummer-1].Events.Add(ITEvenementen.EvenementInstantie[chklstbxInschrijven.CheckedIndices[i]]);
                ITEvenementen.EvenementInstantie[chklstbxInschrijven.CheckedIndices[i]].AantalInschrijvingen++;
            }
            MessageBox.Show("Inschrijven gelukt", "Inschrijven");
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
