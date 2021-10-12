using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Evenement
    {    
        public string EvenementNaam; // Ronde van Eindhoven
        public DateTime Datum; // Datum van het evenement
        public int AantalVakken; // Aantal vakken beschikbaar
        public int AantalStoelen; // Aantal stoelen beschikbaar (is ook max aantal bezoekers)
        public Evenement(string EvenementNaam, DateTime Datum, int AantalVakken, int AantalStoelen)
        {
            this.EvenementNaam = EvenementNaam;
            this.Datum = Datum;
            this.AantalVakken = AantalVakken;
            this.AantalStoelen = AantalStoelen;
        }
    }
}
