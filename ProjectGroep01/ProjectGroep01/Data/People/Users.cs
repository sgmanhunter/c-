using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGroep01.Data.Evenementen;

namespace ProjectGroep01.Data.People
{
    class Users:List<User>
    {
        #region datamembers
        private static Users ledenInstantie = new Users();
        private int huidigLidNummer;
        #endregion

        #region properties
        public static Users UsersInstantion
        {
            get { return ledenInstantie; }
            private set { ledenInstantie = value; }
        }
        #endregion

        #region constructor
        private Users()
        {
            huidigLidNummer = 0;
        }
        #endregion

        #region methods
        public int BerekenNieuwLidNummer()
        {
            huidigLidNummer++;
            return huidigLidNummer;
        }
        #endregion

    }
}
