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
            // Maak bezoekers
            MaakBezoekerTestData();

            // Maak vakken
            List<Vak> vakken = MaakVakken();

            // Maak evenement
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            Console.WriteLine(evenement.EvenementNaam);
            Console.WriteLine(evenement.MaxAantalBezoekers + " bezoekers welkom\n");

            Vak vakA = vakken[0];
            Vak vakB = vakken[1];
            Vak vakC = vakken[2];

            // Bezoekers plaatsen
            foreach (var bezoeker in bezoekers)
            {
                if(vakA.AantalBezoekersInDitVak < vakA.TotaalAantalStoelen)
                {
                    vakA.PlaatsBezoeker(bezoeker);
                }
                else if(vakB.AantalBezoekersInDitVak < vakB.TotaalAantalStoelen)
                {
                    vakB.PlaatsBezoeker(bezoeker);
                }
                else
                {
                    vakC.PlaatsBezoeker(bezoeker);
                }                      
            }

            // UI
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
            bezoekers.Add(new Bezoeker("Bezoeker08", 33));
            bezoekers.Add(new Bezoeker("Bezoeker09", 11));
            bezoekers.Add(new Bezoeker("Bezoeker10", 14));
            bezoekers.Add(new Bezoeker("Bezoeker11", 16));
            bezoekers.Add(new Bezoeker("Bezoeker12", 53));
            bezoekers.Add(new Bezoeker("Bezoeker13", 30));
            bezoekers.Add(new Bezoeker("Bezoeker14", 41));
            bezoekers.Add(new Bezoeker("Bezoeker15", 44));
            bezoekers.Add(new Bezoeker("Bezoeker16", 49));
            bezoekers.Add(new Bezoeker("Bezoeker17", 15));
            bezoekers.Add(new Bezoeker("Bezoeker18", 12));
            bezoekers.Add(new Bezoeker("Bezoeker19", 11));
            bezoekers.Add(new Bezoeker("Bezoeker20", 6));
            bezoekers.Add(new Bezoeker("Bezoeker21", 8));
            bezoekers.Add(new Bezoeker("Bezoeker22", 27));
            bezoekers.Add(new Bezoeker("Bezoeker23", 26));
            bezoekers.Add(new Bezoeker("Bezoeker24", 28));
            bezoekers.Add(new Bezoeker("Bezoeker25", 50));
            bezoekers.Add(new Bezoeker("Bezoeker26", 56));
            bezoekers.Add(new Bezoeker("Bezoeker27", 55));
            bezoekers.Add(new Bezoeker("Bezoeker28", 35));
            bezoekers.Add(new Bezoeker("Bezoeker29", 37));
            bezoekers.Add(new Bezoeker("Bezoeker30", 72));
            bezoekers.Add(new Bezoeker("Bezoeker31", 77));
            bezoekers.Add(new Bezoeker("Bezoeker32", 19));
            bezoekers.Add(new Bezoeker("Bezoeker33", 22));
            bezoekers.Add(new Bezoeker("Bezoeker34", 80));
            bezoekers.Add(new Bezoeker("Bezoeker36", 63));
            bezoekers.Add(new Bezoeker("Bezoeker37", 33));
            bezoekers.Add(new Bezoeker("Bezoeker38", 23));
            bezoekers.Add(new Bezoeker("Bezoeker39", 38));
            bezoekers.Add(new Bezoeker("Bezoeker40", 40));
        }

        private static List<Vak> MaakVakken()
        {
            List<Vak> Vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 5);
            Vak vakB = new Vak("B", 3, 7);
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
