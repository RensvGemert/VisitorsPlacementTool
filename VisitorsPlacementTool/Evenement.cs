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
        public List<Vak> Vakken = new List<Vak>();

        public Evenement(string evenementNaam, List<Vak> vakken)
        {
            EvenementNaam = evenementNaam;
            MaxAantalBezoekers = BerekenMaxAantalBezoekers(vakken);
        }

        public int BerekenMaxAantalBezoekers(List<Vak> vakken)
        {
            int MaxAantalBezoekers = 0;
            foreach (var vak in vakken)
            {
                MaxAantalBezoekers += vak.TotaalAantalStoelen;
            }
            return MaxAantalBezoekers;
        }

        public void PlaatsBezoekers(List<Bezoeker> bezoekers, List<Vak> vakken)
        {
            foreach (var bezoeker in bezoekers)
            {
                for (int i = 0; i < vakken.Count; i++)
                {
                    if ((bezoeker.IsKind() && vakken[i].IsErPlekOpRij1(bezoeker)) || !bezoeker.IsKind())
                    {
                        if (vakken[i].AantalBezoekersInDitVak < vakken[i].TotaalAantalStoelen)
                        {
                            bezoeker.IsGeplaatst = vakken[i].PlaatsBezoeker(bezoeker);                           
                            break;
                        }
                    }                
                }
                if (!bezoeker.IsGeplaatst)
                {
                    EvenementVolBericht(bezoeker);
                }        
            }      
        }

        public void RenderDetails()
        {
            Console.WriteLine(EvenementNaam);
            Console.WriteLine(MaxAantalBezoekers + " bezoekers welkom\n");
        }

        public void EvenementVolBericht(Bezoeker bezoeker)
        {
            Console.WriteLine(bezoeker.Naam + " kon niet worden geplaatst, evenement zit vol!");
            Console.WriteLine();
        }
    }
}
