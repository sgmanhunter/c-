using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Data.People;
using ProjectGroep01.Data.Evenementen;

namespace ProjectGroep01.View
{
    public partial class UitschrijvenEventForm : Form
    {
        private int lidnummer;

        public UitschrijvenEventForm(int nummer)
        {
            InitializeComponent();
            InitCheckListBoxUitschrijven();
            lidnummer = nummer;
        }

        private void InitCheckListBoxUitschrijven()
        {
            chklstbxUitschrijven.Items.Clear();
            for (int i = 0; i < Users.UsersInstantion[lidnummer].Events.Count; i++)
                chklstbxUitschrijven.Items.Add(Users.UsersInstantion[lidnummer].Events[i].EventNaam);
        }

        private void btnUitschrijven_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstbxUitschrijven.CheckedIndices.Count; i++)
            {
                Users.UsersInstantion[lidnummer-1].Events.RemoveAt(chklstbxUitschrijven.CheckedIndices[i]);
                ITEvents.EventsInstantion[chklstbxUitschrijven.CheckedIndices[i]].AantalInschrijvingen--;
            }
            MessageBox.Show("Uitschrijven gelukt", "Uitschrijven");
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
