using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEvents.data.People;

namespace ITEvents.data.Evenementen
{
    public enum EVENT_TYPE
    {
        IT_EVENT
    }

    public class EvenementFactory
    {
        private static EvenementFactory FactSingle = new EvenementFactory();
        public static EvenementFactory Singleton
        {
            get
            {
                return FactSingle;
            }
        }

        private EvenementFactory()
        { }

        public IEvenement MakeEvent(EVENT_TYPE type, MakeEventArgs args)
        {
            IEvenement e = null;
            switch (type)
            {
                case EVENT_TYPE.IT_EVENT:
                    e = new ITEvenement(args.Naam, args.Plaats, args.AantalInschrijvingen, args.AantalPlaatsen);
                    break;
            }
            return e;
        }

        public void AddEvent(IEvenement e)
        {
            // alle databank stuff
            // databank.addItEvent(e);
        }


        public class MakeEventArgs
        {
            public string Naam { get; set; }
            public Plaats Plaats { get; set; }
            public int AantalPlaatsen { get; set; }
            public int AantalInschrijvingen { get; set; }
        }
    }
}
