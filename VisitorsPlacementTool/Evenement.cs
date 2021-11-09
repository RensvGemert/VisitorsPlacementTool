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
        public int MaxAantalBezoekers;

        public Evenement(string EvenementNaam, DateTime Datum, int MaxAantalBezoekers)
        {
            this.EvenementNaam = EvenementNaam;
            this.Datum = Datum;
            this.MaxAantalBezoekers = MaxAantalBezoekers;
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
