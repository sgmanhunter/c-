using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGroep01.Model.Events
{
    class ITEvents:List<ITEvent>
    {
        #region datamembers
        private static ITEvents eventInstantion = new ITEvents();
        private int currentEventNumber;
        public delegate void NotifyHandler();
        public event NotifyHandler NotifyObservers;
        #endregion

        #region properties
        public static ITEvents EventInstantion
        {
            get { return eventInstantion; }
            private set { eventInstantion = value; }
        }
        #endregion

        #region constructor
        private ITEvents()
        {
            currentEventNumber = 0;
            NotifyObservers += ITEvents_NotifyObservers;
        }
        #endregion

        #region methods
        public int CalculateNewEventNumber()
        {
            currentEventNumber++;
            return currentEventNumber;
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
