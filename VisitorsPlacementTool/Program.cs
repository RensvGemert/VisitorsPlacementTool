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
            Bezoeker bezoeker6 = new Bezoeker("bezoeker6", 15);
            Bezoeker bezoeker7 = new Bezoeker("bezoeker7", 16);
            Bezoeker bezoeker8 = new Bezoeker("bezoeker8", 17);

            // Lijst van alle bezoekers
            List<Bezoeker> alleBezoekers = new List<Bezoeker>();
            alleBezoekers.Add(bezoeker1);
            alleBezoekers.Add(bezoeker2);
            alleBezoekers.Add(bezoeker3);
            alleBezoekers.Add(bezoeker4);
            alleBezoekers.Add(bezoeker5);
            alleBezoekers.Add(bezoeker6);
            alleBezoekers.Add(bezoeker7);
            alleBezoekers.Add(bezoeker8);

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
            Vak vak = new Vak("A", 15, 5); // "(vakNaam)", (maxAantalBezoekersInVak), (aantalStoelenPerRij)

            // Kinderen plaatsen
            Console.WriteLine("Kinderen plaatsen: ");
            foreach (var bezoeker in alleKinderen)
            {
                if (evenement.ZijnErPlekkenBeschikbaar() == true)
                {
                    vak.PlaatsBezoeker(bezoeker);
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
                    vak.PlaatsBezoeker(bezoeker);
                    evenement.HuidigAantalBezoekers++;
                }
                else
                {
                    evenement.EvenementZitVolBericht();
                }
            }
            Console.ReadLine();
        }
    }
}
