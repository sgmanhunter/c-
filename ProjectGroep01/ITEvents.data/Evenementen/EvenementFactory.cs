using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEvents.data.People;

namespace ITEvents.data.Evenementen
{
    public abstract class EvenementFactory
    {

        public abstract IEvenement MakeEvent(MakeEventArgs args);
        public void AddEvent(IEvenement e);


        public class MakeEventArgs
        {
            public string Naam { get; set; }
            public Plaats Plaats { get; set; }
            public int AantalPlaatsen { get; set; }
            public int AantalInschrijvingen { get; set; }
        }
    }
}
