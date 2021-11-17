using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Evenement
    {    
        public string EvenementNaam { get; set; } 
        public int MaxAantalBezoekers { get; set; }

        public Evenement(string evenementNaam, int maxAantalBezoekers)
        {
            EvenementNaam = evenementNaam;
            MaxAantalBezoekers = maxAantalBezoekers;
        }

        public void EvenementZitVolBericht()
        {
            Console.WriteLine("Evenement zit vol!");
        }



    }
}
