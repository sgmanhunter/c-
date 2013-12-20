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
using ProjectGroep01.Controller;

namespace ProjectGroep01.View
{
    public partial class MakeEventForm : Form
    {
        public MakeEventForm()
        {
            InitializeComponent();
        }
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
                Controller.Controller.ControllerInstantion.ClickMakeEvent(txtBoxEventName, dtpDate, txtBoxStreetname, 
                    txtBoxHousenumber, txtBoxCity, txtBoxNumberOfPlaces,errorProvider);
        }
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
