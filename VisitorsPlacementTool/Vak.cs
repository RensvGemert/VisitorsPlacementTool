using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Vak
    {
        public string vakNaam;
        public int huidigAantalBezoekersInVak = 0;
        public int maximaalAantalBezoekersInVak;
        public int rijBreedte;       
        public int bezoekersOpDezeRij;
        public int stoelNummer = 1;
        public int rij = 1;


        public Vak(string vakNaam, int maximaalAantalPlekkenInVak, int rijBreedte)
        {
            this.vakNaam = vakNaam;
            this.maximaalAantalBezoekersInVak = maximaalAantalPlekkenInVak;
            this.rijBreedte = rijBreedte;
        }

        public bool IsErPlekInVak()
        {
            if (huidigAantalBezoekersInVak < maximaalAantalBezoekersInVak)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInVak(Bezoeker bezoeker)
        {
            if(IsErPlekInVak() == true)
            {
                huidigAantalBezoekersInVak++;
                return true;
            }
            VakZitVolBericht(bezoeker);
            return false;
        }

        public bool IsErPlekOpDezeRij()
        {
            if (bezoekersOpDezeRij < rijBreedte)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInRij(Bezoeker bezoeker)
        {
            if (PlaatsBezoekerInVak(bezoeker) == true && IsErPlekOpDezeRij() == true)
            {
                bezoekersOpDezeRij++;
                return true;
            }
            Console.WriteLine(bezoeker.Naam + " moet worden verplaatst naar rij 2");
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
