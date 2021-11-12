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
            MaakEvenement();

            MaakTestVak();

            MaakBezoekerTestData();
            ToonAlleBezoekers();
            ToonAlleKinderen();
            ToonAlleVolwassenen();
        }
          
        private static void MaakEvenement()
        {
            Console.WriteLine("Evenement ");
            Evenement evenement = new Evenement("Parcour Eindhoven", DateTime.Today, 50);
            Console.WriteLine($"{evenement.EvenementNaam} \n {evenement.Datum} \n");
        }

        private static void MaakTestVak()
        {
            Vak vak = new Vak("A", 3, 3);
            Console.WriteLine();
        }

        private static void MaakBezoekerTestData()
        {
            bezoekers.Add(new Bezoeker { Naam = "bezoeker01", Leeftijd = 21 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker02", Leeftijd = 12 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker03", Leeftijd = 15 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker04", Leeftijd = 14 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker05", Leeftijd = 8 });
            bezoekers.Add(new Bezoeker { Naam = "bezoeker06", Leeftijd = 18 });
        }

        private static void ToonAlleBezoekers()
        {
            Console.WriteLine("Alle bezoekers: ");
            foreach (var bezoeker in bezoekers)
            {
                Console.WriteLine($"Naam: { bezoeker.Naam} Leeftijd: {bezoeker.Leeftijd}");
            }
            Console.WriteLine();
        }

        private static void ToonAlleKinderen()
        {
            Console.WriteLine("Alle kinderen:");
            foreach (var bezoeker in bezoekers)
            {
                if(bezoeker.IsKind() == true)
                {
                    Console.WriteLine($"Naam: { bezoeker.Naam } Leeftijd: {bezoeker.Leeftijd}");
                }
            }
            Console.WriteLine();
        }

        private static void ToonAlleVolwassenen()
        {
            Console.WriteLine("Alle volwassenen:");
            foreach (var bezoeker in bezoekers)
            {
                if (bezoeker.IsKind() == false)
                {
                    Console.WriteLine($"Naam: { bezoeker.Naam } Leeftijd: {bezoeker.Leeftijd}");
                }
            }
            Console.WriteLine();
        }
    }
}
