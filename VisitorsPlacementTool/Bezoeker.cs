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

        public bool IsGeplaatst = false;

        private int MinimumLeeftijd = 12;

        public Bezoeker(string naam, int leeftijd)
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;
            this.IsGeplaatst = false;
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
