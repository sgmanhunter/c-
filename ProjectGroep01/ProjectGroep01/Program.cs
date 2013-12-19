using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroep01.View;
using ProjectGroep01.Data.Database;

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
            Database.DatabankInstantion.ReadUsers();
            Database.DatabankInstantion.ReadEvents();
            Database.DatabankInstantion.ReadUsersAndEvents();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }
    }
}
