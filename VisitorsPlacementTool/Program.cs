using System;
using System.Collections.Generic;
using System.Linq;

namespace VisitorsPlacementTool
{
    class Program
    {
        private static List<Bezoeker> bezoekers = new List<Bezoeker>();
        static void Main(string[] args)
        {
            MaakBezoekerTestData();
            ToonAlleBezoekers();
            ToonAlleKinderen();
            ToonAlleVolwassenen();

            MaakEvenement();
            Console.ReadLine();
        }
           
        // Maak testdata
        private static void MaakBezoekerTestData()
        {
            bezoekers.Add(new Bezoeker { Naam = "bezoeker01", Leeftijd = 21 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker02", Leeftijd = 12 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker03", Leeftijd = 15 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker04", Leeftijd = 14 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker05", Leeftijd = 8 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker06", Leeftijd = 18 });
        }

        // Maak evenement
        private static void MaakEvenement()
        {
            Console.WriteLine("Evenement: ");
            Evenement evenement = new Evenement("Parcour Eindhoven", DateTime.Today, 50);
            Console.WriteLine($"{evenement.EvenementNaam} \n {evenement.Datum} \n");
        }

        // Alle bezoekers
        private static void ToonAlleBezoekers()
        {
            Console.WriteLine("Alle bezoekers: ");
            foreach (var bezoeker in bezoekers)
            {
                Console.WriteLine($"Naam: { bezoeker.Naam} Leeftijd: {bezoeker.Leeftijd}");
            }
            Console.WriteLine();
        }

        // Alle kinderen
        private static void ToonAlleKinderen()
        {
            Console.WriteLine("Alle kinderen:");
            foreach (var bezoeker in bezoekers)
            {
                if(bezoeker.Leeftijd <= 12)
                {
                    Console.WriteLine($"Naam: { bezoeker.Naam } Leeftijd: {bezoeker.Leeftijd}");
                }
            }
            Console.WriteLine();
        }

        // Alle volwassenen
        private static void ToonAlleVolwassenen()
        {
            Console.WriteLine("Alle volwassenen:");
            foreach (var bezoeker in bezoekers)
            {
                if (bezoeker.Leeftijd > 12)
                {
                    Console.WriteLine($"Naam: { bezoeker.Naam } Leeftijd: {bezoeker.Leeftijd}");
                }
            }
            Console.WriteLine();
        }
    }
}
