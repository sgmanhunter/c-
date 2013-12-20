using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Controller;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Data;

namespace ProjectGroep01.View
{
    public partial class SummaryForm : Form, IObserver
    {
        

        public SummaryForm(Data.ShowList t):this(t,0)
        {
        }
        public SummaryForm(Data.ShowList t, int userid)
        {
            ITEvents.EventInstantion.NotifyObservers += Updating;
            InitializeComponent();
            ControllerSummary.ControllerInstantion.UserId = userid;
            ControllerSummary.ControllerInstantion.ShowListProperty = t;

            ControllerSummary.ControllerInstantion.ShowList(txtBoxEvent);
        }

        public void Updating()
        {
            ControllerSummary.ControllerInstantion.ShowList(txtBoxEvent);
        }

        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ITEvents.EventInstantion.NotifyObservers -= Updating;
        }
    }
}
