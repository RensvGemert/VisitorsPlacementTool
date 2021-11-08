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
            Bezoeker bezoeker2 = new Bezoeker("bezoeker2", 10);
            Bezoeker bezoeker3 = new Bezoeker("bezoeker3", 22);
            Bezoeker bezoeker4 = new Bezoeker("bezoeker4", 12);
            Bezoeker bezoeker5 = new Bezoeker("bezoeker5", 21);

            // Lijst van alle bezoekers
            List<Bezoeker> alleBezoekers = new List<Bezoeker>();
            alleBezoekers.Add(bezoeker1);
            alleBezoekers.Add(bezoeker2);
            alleBezoekers.Add(bezoeker3);
            alleBezoekers.Add(bezoeker4);
            alleBezoekers.Add(bezoeker5);

            // Lijst van alle kinderen
            List<Bezoeker> alleKinderen = new List<Bezoeker>();

            // Lijst van alle volwassene
            List<Bezoeker> alleVolwassene = new List<Bezoeker>();

            foreach (var bezoeker in alleBezoekers)
            {
                if(bezoeker.IsKind() == true)
                {
                    alleKinderen.Add(bezoeker);
                }
                else
                {
                    alleVolwassene.Add(bezoeker);
                }              
            }

            Console.WriteLine("Alle kinderen: ");
            foreach (var kind in alleKinderen)
            {
                Console.WriteLine(kind.Naam);
            }

            Console.WriteLine("\nalle volwassenen: ");

            foreach (var volwassene in alleVolwassene)
            {
                Console.WriteLine(volwassene.Naam);
            }

            //List<Bezoeker> gesorteerdeLijst = new List<Bezoeker>();
            //gesorteerdeLijst.AddRange(alleKinderen);
            //gesorteerdeLijst.AddRange(alleVolwassene);

            //foreach (var bezoeker in gesorteerdeLijst)
            //{
            //    Console.WriteLine(bezoeker.Naam + " " + bezoeker.Leeftijd);
            //}

            // Vak A 
            Vak vakA = new Vak("A");

            // break
            Console.WriteLine();

            // Kinderen plaatsen
            Console.WriteLine("Kinderen plaatsen: ");
            foreach (var bezoeker in alleKinderen)
            {
                vakA.PlaatsBezoeker(bezoeker);
            }

            // break
            Console.WriteLine();

            // Volwassenen plaatsen
            Console.WriteLine("Volwassenen plaatsen: ");
            foreach (var bezoeker in alleVolwassene)
            {
                vakA.PlaatsBezoeker(bezoeker);
            }

        }
    }
}
