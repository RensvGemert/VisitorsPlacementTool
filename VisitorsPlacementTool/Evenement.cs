using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Evenement
    {    
        public string EvenementNaam; // Ronde van Eindhoven
        public DateTime Datum; // Datum van het evenement
        public int HuidigAantalBezoekers = 0;
        public int MaxAantalBezoekers = 2;

        public Evenement(string EvenementNaam, DateTime Datum)
        {
            this.EvenementNaam = EvenementNaam;
            this.Datum = Datum;
        }

        public int AantalBezoekersWelkom()
        {
            int aantalBezoekersWelkom = MaxAantalBezoekers - HuidigAantalBezoekers;
            return aantalBezoekersWelkom;
        }

        public bool ZijnErPlekkenBeschikbaar()
        {
            if (HuidigAantalBezoekers < MaxAantalBezoekers)
            {
                Console.WriteLine("Er is nog plek voor " + AantalBezoekersWelkom() + " bezoeker(s)");
                return true;
            }
            return false;
        }

        public void EvenementZitVolBericht()
        {
            Console.WriteLine("Evenement zit vol!");
        }
    }
}
