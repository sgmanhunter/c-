using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Data.Evenementen
{
    class ITEvents:List<ITEvent>
    {
        #region datamembers
        private static ITEvents evenementInstantie = new ITEvents();
        private int huidigEventNummer;
        public delegate void NotifyHandler();
        public event NotifyHandler NotifyObservers;
        #endregion

        #region properties
        public static ITEvents EventsInstantion
        {
            get { return evenementInstantie; }
            private set { evenementInstantie = value; }
        }
        #endregion

        #region constructor
        private ITEvents()
        {
            huidigEventNummer = 0;
            NotifyObservers += ITEvents_NotifyObservers;
        }
        #endregion

        #region methods
        public int BerekenNieuwEventNummer()
        {
            huidigEventNummer++;
            return huidigEventNummer;
        }
        private void ITEvents_NotifyObservers()
        {
        }
        public new void Add(ITEvent ite)
        {
            base.Add(ite);
            NotifyObservers();
        }
        #endregion

    }
}
