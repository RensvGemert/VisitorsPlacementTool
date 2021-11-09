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
            Evenement evenement = new Evenement("Parcour Eindhoven", DateTime.Today, 50);
            Console.WriteLine(evenement.EvenementNaam);
            Console.WriteLine(evenement.Datum.ToShortDateString());

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

            // Vak A 
            Vak vakA = new Vak("A", 15, 5); // Vak "A", heeft maximaal 15 zitplaatsen en 5 stoelen per rij.

            // Kinderen plaatsen
            Console.WriteLine("Kinderen plaatsen: ");
            foreach (var bezoeker in alleKinderen)
            {
                if (evenement.ZijnErPlekkenBeschikbaar() == true)
                {
                    vakA.PlaatsBezoeker(bezoeker);
                    evenement.HuidigAantalBezoekers++;
                }
                else
                {
                    evenement.EvenementZitVolBericht();
                }
            }

            // Volwassenen plaatsen
            Console.WriteLine("Volwassenen plaatsen: ");
            foreach (var bezoeker in alleVolwassene)
            {
                if (evenement.ZijnErPlekkenBeschikbaar() == true)
                {
                    vakA.PlaatsBezoeker(bezoeker);
                    evenement.HuidigAantalBezoekers++;
                }
                else
                {
                    evenement.EvenementZitVolBericht();
                }
            }
        }
    }
}
