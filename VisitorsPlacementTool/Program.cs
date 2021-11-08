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
            bezoeker1.IsKind();

            // Vak
            Vak vak = new Vak("A");
            Console.WriteLine(vak.vakNaam);
            Console.WriteLine(vak.IsErPlekInVak());
            Console.WriteLine(vak.PlaatsBezoekerInVak(bezoeker1));
            Console.WriteLine(vak.huidigAantalPlekken);

            // Rij
            Rij rij = new Rij();

            // Stoel
            Stoel stoel = new Stoel();

          
        }
    }
}
