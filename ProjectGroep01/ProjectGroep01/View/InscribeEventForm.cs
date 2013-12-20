using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.Model.Events;
using ProjectGroep01.Model.People;
using ProjectGroep01.Data.Database;
using ProjectGroep01.Controller;

namespace ProjectGroep01.View
{
    public partial class InscribeEventForm : Form
    {
        private int userid;

        public InscribeEventForm(int userid)
        {
            InitializeComponent();
            ControllerInscribeAndWriteOut.ControllerInstantion.InitCheckListBoxInscribe(chklstbxInscribe, userid);
            this.userid = userid;
        }

        

        private void btnInscribe_Click(object sender, EventArgs e)
        {
            ControllerInscribeAndWriteOut.ControllerInstantion.ClickBtnInscribe(chklstbxInscribe, userid);
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
