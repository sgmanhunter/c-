using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Model
{
    class Leden:List<Lid>
    {
        #region datamembers
        private static Leden ledenInstantie = new Leden();
        private int huidigLidNummer;
        #endregion

        #region properties
        public static Leden LedenInstantie
        {
            get { return ledenInstantie; }
            private set { ledenInstantie = value; }
        }
        #endregion

        #region constructor
        private Leden()
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
