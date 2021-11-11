using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Bezoeker
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        private int MinimumLeeftijd = 12;
        public Bezoeker()
        {

        }

        public Bezoeker(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public bool IsKind()
        {
            if (this.Leeftijd <= MinimumLeeftijd)
            {          
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
