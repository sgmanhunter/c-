using ITEvents.data.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEvents.data.Evenementen
{
    public interface IEvenement
    {
        int Nummer;
        string Naam;
        Plaats Plaats;
        int AantalInschrijvingen;
        int AantalPlaatsen;        
    }
}
