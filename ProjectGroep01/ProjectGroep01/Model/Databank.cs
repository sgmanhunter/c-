using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjectGroep01.Model
{
    class Databank
    {
        private string connectionString;

        private string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public Databank()
        {
            ConnectionString = "Network Library=databasename;Data Source=;database=;User id=;Password=;";
            SqlConnection connect = new SqlConnection(@ConnectionString);
            if (connect.Database != "databasename")
                throw new Exception("Geen connectie mogelijk, raadpleeg hulp!");
        }
    }
}
