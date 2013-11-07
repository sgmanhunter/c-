using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Model
{
    class ITEvents:List<ITEvent>
    {
        #region datamembers
        private static ITEvents eventsInstantie = new ITEvents();
        private int huidigEventNummer;
        #endregion 

        #region properties
        public static ITEvents EventsInstantie
        {
            get { return eventsInstantie; }
            private set { eventsInstantie = value; }
        }
        #endregion 

        #region constructor
        private ITEvents()
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
