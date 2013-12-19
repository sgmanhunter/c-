using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Model.People;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Data.Database;

namespace ProjectGroep01.View
{
    public partial class WriteOutEventForm : Form
    {
        private int userid;

        public WriteOutEventForm(int nummer)
        {
            InitializeComponent();
            InitCheckListBoxWriteOut();
            userid = nummer;
        }

        private void InitCheckListBoxWriteOut()
        {
            chklstbxWriteOut.Items.Clear();
            for (int i = 0; i < Users.UserInstantion[userid].Events.Count; i++)
                chklstbxWriteOut.Items.Add(Users.UserInstantion[userid].Events[i].EventName);
        }

        private void btnWriteOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstbxWriteOut.CheckedIndices.Count; i++)
            {
                int index = ITEvents.EventInstantion.IndexOf(Users.UserInstantion[userid - 1].Events[chklstbxWriteOut.CheckedIndices[i]]);
                Users.UserInstantion[userid - 1].Events.RemoveAt(chklstbxWriteOut.CheckedIndices[i]);
                ITEvents.EventInstantion[chklstbxWriteOut.CheckedIndices[i]].NumberOfInscribers--;
                Database.DatabankInstantion.DeleteUserAndEvent(Users.UserInstantion[userid - 1], ITEvents.EventInstantion[index]);
            }
            MessageBox.Show("Uitschrijven voltooid", "Uitschrijven");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
