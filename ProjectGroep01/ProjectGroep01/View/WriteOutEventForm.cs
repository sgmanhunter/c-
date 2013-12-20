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
    public partial class WriteOutEventForm : Form
    {
        private int userid;

        public WriteOutEventForm(int nummer)
        {
            InitializeComponent();
            userid = nummer;
            ControllerInscribeAndWriteOut.ControllerInstantion.InitCheckListBoxWriteOut(chklstbxWriteOut,userid);
        }

        

        private void btnWriteOut_Click(object sender, EventArgs e)
        {
            ControllerInscribeAndWriteOut.ControllerInstantion.ClickBtnWriteOut(chklstbxWriteOut, userid);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
