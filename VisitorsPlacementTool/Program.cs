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

            List<Vak> vakken = MaakVakken();
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            Console.WriteLine(evenement.EvenementNaam);
            Console.WriteLine(evenement.MaxAantalBezoekers + " bezoekers welkom\n");

            Vak vakA = vakken[0];
            Vak vakB = vakken[1];
            Vak vakC = vakken[2];

            foreach (var bezoeker in bezoekers)
            {
                vakA.PlaatsBezoekerInVak(bezoeker);
            }

            foreach (var vak in vakken)
            {
                Console.WriteLine("Vak: " + vak.VakLetter);
                foreach (var rij in vak.rijen)
                {
                    foreach (var stoel in rij.Stoelen)
                    {
                        if (stoel.Bezoeker != null)
                        {
                            Console.WriteLine(stoel.StoelCode + " " + stoel.Bezoeker.Naam);
                        }
                        else
                        {
                            Console.WriteLine(stoel.StoelCode);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //// Print Vak A:
            //foreach (var rij in vakA.rijen)
            //{
            //    foreach (var stoel in rij.Stoelen)
            //    {                 
            //        if (stoel.Bezoeker != null)
            //        {
            //            Console.WriteLine(stoel.StoelCode + " " + stoel.Bezoeker.Naam);
            //        }
            //        else
            //        {
            //            Console.WriteLine(stoel.StoelCode);
            //        }                 
            //    }
            //}

            //BerekenAantalBezoekers();
            //BerekenAantalKinderen(bezoekers);
            //BerekenAantalVolwassenen(bezoekers);

            //ToonAlleBezoekers();
            //ToonAlleKinderen();
            //ToonAlleVolwassenen();
        }

        private static void MaakBezoekerTestData()
        {
            bezoekers.Add(new Bezoeker("Bezoeker01", 11));
            bezoekers.Add(new Bezoeker("Bezoeker02", 22));
            bezoekers.Add(new Bezoeker("Bezoeker03", 11));
            bezoekers.Add(new Bezoeker("Bezoeker04", 10));
            bezoekers.Add(new Bezoeker("Bezoeker05", 11));
            bezoekers.Add(new Bezoeker("Bezoeker06", 23));
            bezoekers.Add(new Bezoeker("Bezoeker07", 43));
            bezoekers.Add(new Bezoeker("Bezoeker08", 43));
            bezoekers.Add(new Bezoeker("Bezoeker09", 43));
            //bezoekers.Add(new Bezoeker("Bezoeker10", 43));
        }

        private static List<Vak> MaakVakken()
        {
            List<Vak> Vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 5);
            Vak vakB = new Vak("B", 3, 5);
            Vak vakC = new Vak("C", 3, 5);

            Vakken.Add(vakA);
            Vakken.Add(vakB);
            Vakken.Add(vakC);
            return Vakken;
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
