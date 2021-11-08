using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Vak
    {
        public string vakNaam; // vak A, B, C of D
        public int huidigAantalPlekkenInVak = 0;
        public int maximaalAantalPlekkenInVak = 10;
        public int rij = 1;
        public int stoelNummer = 1;
        

        public Vak(string vakNaam)
        {
            this.vakNaam = vakNaam;
        }

        public bool IsErPlekInVak()
        {
            if (huidigAantalPlekkenInVak < maximaalAantalPlekkenInVak)
            {
                return true;
            }
            return false;
        }

       
        public bool PlaatsBezoekerInVak(Bezoeker bezoeker)
        {
            if(IsErPlekInVak() == true)
            {
                huidigAantalPlekkenInVak++;
                return true;
            }
            VakZitVolBericht(bezoeker);
            return false;
        }


        public bool PlaatsBezoekerInRij(Bezoeker bezoeker)
        {
            if (PlaatsBezoekerInVak(bezoeker) == true)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoeker(Bezoeker bezoeker)
        {
            if (PlaatsBezoekerInRij(bezoeker) == true)
            {
                Console.WriteLine(bezoeker.Naam + " Word geplaatst op stoel: " + vakNaam + rij + "-" +  stoelNummer);
                stoelNummer++;
                return true;
            }
            return false;
        }

        public void VakZitVolBericht(Bezoeker bezoeker)
        {
            Console.WriteLine(bezoeker.Naam + " kan niet worden geplaatst omdat dit vak vol is.");
        }
    }
}
