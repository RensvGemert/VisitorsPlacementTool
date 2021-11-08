using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Vak
    {
        public List<Vak> VakA = new List<Vak>();
        public string vakNaam; // vak A, B, C of D
        public int huidigAantalPlekken = 0;
        public int maximaalAantalPlekken = 10;
        

        public Vak(string vakNaam)
        {
            this.vakNaam = vakNaam;
        }

        public bool IsErPlekInVak()
        {
            if (huidigAantalPlekken < maximaalAantalPlekken)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInVak(Bezoeker bezoeker)
        {
            if(IsErPlekInVak() == true)
            {
                Console.WriteLine(bezoeker.Naam + " word toegevoegd aan vak: " + this.vakNaam);
                huidigAantalPlekken++;
                return true;
            }
            return false;
        }
    }
}
