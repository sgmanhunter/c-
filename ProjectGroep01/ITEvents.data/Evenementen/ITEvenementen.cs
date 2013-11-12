using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEvents.data.Evenementen
{
    class ITEvenementen:List<ITEvenement>
    {
        #region datamembers
        private static ITEvenementen eventsInstantie = new ITEvenementen();
        private int huidigEventNummer;
        #endregion 

        #region properties
        public static ITEvenementen EventsInstantie
        {
            get { return eventsInstantie; }
            private set { eventsInstantie = value; }
        }
        #endregion 

        #region constructor
        private ITEvenementen()
        {
            huidigEventNummer = 0;
        }
        #endregion
 
        #region methods
        public int BerekenNieuwEventNummer()
        {
            return huidigEventNummer++;
        }
        #endregion
    }
}
