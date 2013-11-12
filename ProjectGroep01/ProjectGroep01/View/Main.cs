using ITEvents.data.Evenementen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ITEvents.data.Evenementen;


namespace ProjectGroep01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            grpBoxLoggedIn.Visible = true;
            grpBoxLogin.Visible = false;


            EvenementFactory.MakeEventArgs args = new EvenementFactory.MakeEventArgs();
            args.Naam = "test";
            args.Plaats = new ITEvents.data.People.Plaats() { HuisNummer = "1", Stad = "Sats", Straatnaam = "diksmuide" };
            IEvenement it = EvenementFactory.Singleton.MakeEvent(EVENT_TYPE.IT_EVENT, args);

        }
    }
}
