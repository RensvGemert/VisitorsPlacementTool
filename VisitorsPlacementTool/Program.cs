using System;
using System.Collections.Generic;
using System.Linq;

namespace VisitorsPlacementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Evenement
            Evenement evenement = new Evenement("Parcour Eindhoven", DateTime.Today);
            Console.WriteLine(evenement.EvenementNaam);
            Console.WriteLine(evenement.Datum.ToShortDateString() + "\n");

            // Bezoekers
            Bezoeker bezoeker1 = new Bezoeker("bezoeker1", 23);

            // Vak
            Vak vakA = new Vak("A");
            vakA.PlaatsBezoekerInVak(bezoeker1);
        }
    }
}
