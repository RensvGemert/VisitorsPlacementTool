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

            // Vak
            Vak vak = new Vak("A");
            Console.WriteLine(vak.vakNaam);

            // Rij
            Rij rij = new Rij();

            // Stoel
            Stoel stoel = new Stoel();

            // Bezoekers
            Bezoeker bezoeker1 = new Bezoeker("bezoeker1", 23);
            bezoeker1.IsKind();
        }
    }
}
