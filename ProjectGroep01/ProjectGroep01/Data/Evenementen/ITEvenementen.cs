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
        private int huidigEventNummer;
        public delegate void NotifyHandler();
        public event NotifyHandler NotifyObservers;
        #endregion

        #region properties
        public static ITEvenementen EvenementInstantie
        {
            get { return evenementInstantie; }
            private set { evenementInstantie = value; }
        }
        #endregion

        #region constructor
        private ITEvenementen()
        {
            huidigEventNummer = 0;
            NotifyObservers += ITEvenementen_NotifyObservers;
        }
        #endregion

        #region methods
        public int BerekenNieuwEventNummer()
        {
            huidigEventNummer++;
            return huidigEventNummer;
        }
        private void ITEvenementen_NotifyObservers()
        {
        }
        public new void Add(ITEvenement ite)
        {
            base.Add(ite);
            NotifyObservers();
        }
        #endregion

    }
}
