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

            //Console.WriteLine(vakken[0].rijen[0].Stoelen[0].StoelCode);
            //Console.WriteLine(vakken[0].rijen[0].Stoelen[0].Bezoeker.Naam);
            //BerekenAantalBezoekers();
            //BerekenAantalKinderen(bezoekers);
            //BerekenAantalVolwassenen(bezoekers);
            //ToonAlleBezoekers();
            //ToonAlleKinderen();
            //ToonAlleVolwassenen();
        }

        private static void MaakBezoekerTestData()
        {
            bezoekers.Add(new Bezoeker("Kind1", 11));
            bezoekers.Add(new Bezoeker("Kind2", 11));        
            bezoekers.Add(new Bezoeker("Kind3", 11));
            bezoekers.Add(new Bezoeker("Kind4", 11));
            bezoekers.Add(new Bezoeker("Kind5", 11));
            bezoekers.Add(new Bezoeker("Kind6", 11));
            bezoekers.Add(new Bezoeker("Kind7", 11));
            bezoekers.Add(new Bezoeker("Kind8", 11));
            bezoekers.Add(new Bezoeker("Kind9", 11));
            bezoekers.Add(new Bezoeker("Kind10", 11));
            bezoekers.Add(new Bezoeker("Volwassenen1", 22));
            bezoekers.Add(new Bezoeker("Volwassenen2", 22));
            bezoekers.Add(new Bezoeker("Volwassenen3", 22));
            bezoekers.Add(new Bezoeker("Volwassenen4", 22));
            bezoekers.Add(new Bezoeker("Volwassenen5", 22));
            bezoekers.Add(new Bezoeker("Volwassenen6", 22));
            bezoekers.Add(new Bezoeker("Volwassenen7", 22));
            bezoekers.Add(new Bezoeker("Volwassenen8", 22));
            bezoekers.Add(new Bezoeker("Kind11", 11));
            bezoekers.Add(new Bezoeker("Kind12", 11));
            bezoekers.Add(new Bezoeker("Kind13", 11));
            bezoekers.Add(new Bezoeker("Kind14", 11));
            bezoekers.Add(new Bezoeker("Volwassene9", 22));
            bezoekers.Add(new Bezoeker("Volwassenen10", 22));
            bezoekers.Add(new Bezoeker("Volwassenen11", 22));
            bezoekers.Add(new Bezoeker("Volwassenen12", 22));
            bezoekers.Add(new Bezoeker("Volwassenen13", 22));
            bezoekers.Add(new Bezoeker("Volwassenen14", 22));
            bezoekers.Add(new Bezoeker("Volwassenen15", 22));
            bezoekers.Add(new Bezoeker("Volwassenen16", 22));
            bezoekers.Add(new Bezoeker("Volwassenen17", 22));
            bezoekers.Add(new Bezoeker("Volwassenen18", 22));
            bezoekers.Add(new Bezoeker("Volwassenen19", 22));
            bezoekers.Add(new Bezoeker("Volwassenen20", 22));
            bezoekers.Add(new Bezoeker("Volwassenen21", 22));

        }

        private static List<Vak> MaakVakken()
        {
            List<Vak> Vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 3);
            Vak vakB = new Vak("B", 3, 3);
            Vak vakC = new Vak("C", 3, 3);

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
