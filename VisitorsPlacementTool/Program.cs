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
            MaakBezoekerTestData();

            Vak vak = MaakVakA();

            foreach (var bezoeker in bezoekers)
            {
                vak.PlaatsBezoeker(bezoeker);
            }

            Console.WriteLine();

            foreach (var rij in vak.rijen)
            {
                foreach (var stoel in rij.Stoelen)
                {
                    Console.WriteLine(stoel);
                }
            }

            Console.WriteLine();

            //BerekenAantalBezoekers();
            //BerekenAantalKinderen(bezoekers);
            //BerekenAantalVolwassenen(bezoekers);

            //ToonAlleBezoekers();
            //ToonAlleKinderen();
            //ToonAlleVolwassenen();
        }
          

        public static void MaakEvenement()
        {
            Console.WriteLine("Evenement");
            Evenement evenement = new Evenement("Parcour Eindhoven", 50);
            Console.WriteLine($"{evenement.EvenementNaam} \n");        
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

        private static Vak MaakVakA()
        {
            Vak vak = new Vak("A", 3, 3);
            return vak;
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

        private static void BerekenAantalBezoekers()
        {
            Console.WriteLine($"Aantal ingeschreven bezoekers: {bezoekers.Count()}");
        }

        private static void BerekenAantalKinderen(List<Bezoeker> bezoekers)
        {
            List<Bezoeker> kinderen = new List<Bezoeker>();
            foreach (var bezoeker in bezoekers)
            {
                if (bezoeker.IsKind() == true)
                {
                    kinderen.Add(bezoeker);
                }
            }
            Console.WriteLine($"Aantal ingeschreven kinderen: {kinderen.Count()}");
        }

        private static void BerekenAantalVolwassenen(List<Bezoeker> bezoekers)
        {
            List<Bezoeker> volwassenen = new List<Bezoeker>();
            foreach (var bezoeker in bezoekers)
            {
                if (bezoeker.IsKind() == false)
                {
                    volwassenen.Add(bezoeker);
                }
            }
            Console.WriteLine($"Aantal ingeschreven volwassenen: {volwassenen.Count()}");
        }
    }
}
