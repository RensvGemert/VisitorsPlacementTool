using System;
using System.Collections.Generic;
using System.Linq;

namespace VisitorsPlacementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Evenement evenement = new Evenement("Ronde van Eindhoven", new DateTime(2021, 10, 12), 4, 5);

            Console.WriteLine("Evenement: " + evenement.EvenementNaam);
            Console.WriteLine("Datum: " + evenement.Datum.ToShortDateString());
            Console.WriteLine("Aantal vakken: " + evenement.AantalVakken);
            Console.WriteLine("Aantal stoelen: " + evenement.AantalStoelen);
        }
    }
}
