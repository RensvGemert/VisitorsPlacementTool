using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Evenement
    {    
        public string EvenementNaam; 
        public DateTime Datum;
        public int HuidigAantalBezoekers = 0;
        public int MaxAantalBezoekers = 4;

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
