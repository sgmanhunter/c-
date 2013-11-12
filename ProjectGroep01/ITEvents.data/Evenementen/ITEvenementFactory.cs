using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITEvents.data.Evenementen;

namespace ITEvents.data.Evenementen
{
    public class ITEvenementFactory : EvenementFactory
    {

        public override ITEvenement MakeEvent(MakeITEvenementArgs args)
        {
            return new ITEvenement(args.Naam, args.Plaats, args.AantalPlaatsen, args.AantalInschrijvingen);
        }

    }


    public class MakeITEvenementArgs : EvenementFactory.MakeEventArgs
    { }
}
