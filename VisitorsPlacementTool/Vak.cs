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
        public int aantalBezoekersInVak = 0;
        public int maxAantalBezoekersInVak;
        public int aantalStoelenOpDezeRij;       
        public int aantalBezoekersOpDezeRij;
        public int stoelNummer = 1;
        public int rijNummer = 1;

        public Vak(string vakNaam, int maxAantalBezoekersInVak, int aantalStoelenPerRij)
        {
            this.vakNaam = vakNaam;
            this.maxAantalBezoekersInVak = maxAantalBezoekersInVak;
            this.aantalStoelenOpDezeRij = aantalStoelenPerRij;
        }

        public bool IsErPlekInVak()
        {
            if (aantalBezoekersInVak < maxAantalBezoekersInVak)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInVak(Bezoeker bezoeker)
        {
            if(IsErPlekInVak() == true)
            {
                aantalBezoekersInVak++;
                return true;
            }
            VakZitVolBericht(bezoeker);
            return false;
        }

        public bool IsErPlekOpDezeRij()
        {
            if (aantalBezoekersOpDezeRij < aantalStoelenOpDezeRij)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInRij(Bezoeker bezoeker)
        {
            if (PlaatsBezoekerInVak(bezoeker) == true && IsErPlekOpDezeRij() == true)
            {
                aantalBezoekersOpDezeRij++;
                return true;
            }
            if(IsErPlekInVak() == true)
            {
                Console.WriteLine(bezoeker.Naam + " moet nog worden geplaatst in het vak");
            }
            return false;
        }

        public bool PlaatsBezoeker(Bezoeker bezoeker)
        {
            if (PlaatsBezoekerInRij(bezoeker) == true)
            {
                Console.WriteLine(bezoeker.Naam + " Word geplaatst op stoel: " + vakNaam + rijNummer + "-" +  stoelNummer);
                stoelNummer++;
                return true;
            }
            return false;
        }

        public void VakZitVolBericht(Bezoeker bezoeker)
        {
            Console.WriteLine(bezoeker.Naam + " kan niet worden geplaatst omdat dit vak vol zit. ");
        }
    }
}
