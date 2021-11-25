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

            // Maak vakken:
            List<Vak> vakken = MaakVakken();

            // Maak evenement:
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            evenement.RenderDetails();

            // Plaatsbezoekers:
            evenement.PlaatsBezoekers(bezoekers, vakken);

            // UI
            RenderUI(vakken);

            //Console.WriteLine(vakken[0].rijen[0].Stoelen[0].StoelCode + " " + vakken[0].rijen[0].Stoelen[0].Bezoeker.Naam);
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
            bezoekers.Add(new Bezoeker("Bezoeker24", 22));
            bezoekers.Add(new Bezoeker("Bezoeker25", 26));
        }

        private static List<Vak> MaakVakken()
        {
            List<Vak> Vakken = new List<Vak>();
            Vak vakA = new Vak("A", 1, 3);
            Vak vakB = new Vak("B", 2, 3);
            Vak vakC = new Vak("C", 3, 5);

            Vakken.Add(vakA);
            Vakken.Add(vakB);
            Vakken.Add(vakC);
            return Vakken;
        }

        private static void RenderUI(List<Vak> vakken)
        {
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
                if (bezoeker.IsKind() == true)
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
