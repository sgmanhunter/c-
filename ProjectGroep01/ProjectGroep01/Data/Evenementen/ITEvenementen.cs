using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Data.Evenementen
{
    class ITEvenementen:List<ITEvenement>
    {
        #region datamembers
        private static ITEvenementen evenementInstantie = new ITEvenementen();
        private int huidigLidNummer;
        #endregion

        #region properties
        public static ITEvenementen EvenementenInstantie
        {
            get { return evenementInstantie; }
            private set { evenementInstantie = value; }
        }
        #endregion

        #region constructor
        private ITEvenementen()
        {
            huidigLidNummer = 0;
        }
        #endregion

        #region methods
        public int BerekenNieuwEventNummer()
        {
            huidigLidNummer++;
            return huidigLidNummer;
        }
        #endregion

    }
}
