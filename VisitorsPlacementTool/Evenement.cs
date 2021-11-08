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

        public Evenement(string EvenementNaam, DateTime Datum)
        {
            this.EvenementNaam = EvenementNaam;
            this.Datum = Datum;
        }
    }
}
