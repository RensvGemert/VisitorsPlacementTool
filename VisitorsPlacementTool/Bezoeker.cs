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

        private readonly int _minimumLeeftijd = 12;

        public Bezoeker(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            IsGeplaatst = false;
        }

        public bool IsKind()
        {
            if (Leeftijd <= _minimumLeeftijd)
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
