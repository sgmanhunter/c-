using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.View;
using ProjectGroep01.Data.Databank;

namespace ProjectGroep01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Databank.DatabankInstantie.ReadUsers();
            Databank.DatabankInstantie.ReadEvents();
            Databank.DatabankInstantie.ReadUsersAndEvents();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }
    }
}
