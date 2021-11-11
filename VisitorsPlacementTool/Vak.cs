using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Vak
    {
        public string VakLetter { get; set; }
        public int MaxAantalBezoekersInVak { get; set; }
        public int AantalStoelenOpDezeRij { get; set; }
        public int AantalBezoekersInVak = 0;
    
        public int AantalBezoekersOpDezeRij;
        public int StoelNummer = 1;
        public int RijNummer = 1;
        public Vak()
        {

        }

        public Vak(string vakLetter, int maxAantalBezoekersInVak, int aantalStoelenOpDezeRij)
        {
            VakLetter = vakLetter;
            MaxAantalBezoekersInVak = maxAantalBezoekersInVak;
            AantalStoelenOpDezeRij = aantalStoelenOpDezeRij;
        }

        public bool IsErPlekInVak()
        {
            if (AantalBezoekersInVak < MaxAantalBezoekersInVak)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInVak(Bezoeker bezoeker)
        {
            if(IsErPlekInVak() == true)
            {
                AantalBezoekersInVak++;
                return true;
            }
            VakZitVolBericht(bezoeker);
            return false;
        }

        public bool IsErPlekOpDezeRij()
        {
            if (AantalBezoekersOpDezeRij < AantalStoelenOpDezeRij)
            {
                return true;
            }
            return false;
        }

        public bool PlaatsBezoekerInRij(Bezoeker bezoeker)
        {
            if (PlaatsBezoekerInVak(bezoeker) == true && IsErPlekOpDezeRij() == true)
            {
                AantalBezoekersOpDezeRij++;
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
                Console.WriteLine(bezoeker.Naam + " Word geplaatst op stoel: " + VakLetter + RijNummer + "-" +  StoelNummer);
                StoelNummer++;
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
