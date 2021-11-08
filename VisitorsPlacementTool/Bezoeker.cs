using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Bezoeker
    {
        public string Naam;
        public int Leeftijd;
        public int MinimumLeeftijd = 12;

        public Bezoeker(string Naam, int Leeftijd)
        {
            this.Naam = Naam;
            this.Leeftijd = Leeftijd;
        }

        // Age check
        public bool IsKind()
        {
            if (this.Leeftijd <= MinimumLeeftijd)
            {
                Console.WriteLine(this.Naam + " is een kind");
                return true;
            }
            else
            {
                Console.WriteLine(this.Naam + " is een volwassene");
                return false;
            }
        }
    }
}
