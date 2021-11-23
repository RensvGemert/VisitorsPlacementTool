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
            Vak vakA = vakken[0];
            Vak vakB = vakken[1];
            Vak vakC = vakken[2];

            foreach (var bezoeker in bezoekers)
            {
                if (vakA.AantalBezoekersInDitVak < vakA.TotaalAantalStoelen)
                {
                    vakA.PlaatsBezoeker(bezoeker);
                }
                else if (vakB.AantalBezoekersInDitVak < vakB.TotaalAantalStoelen)
                {
                    vakB.PlaatsBezoeker(bezoeker);
                }
                else if (vakC.AantalBezoekersInDitVak < vakC.TotaalAantalStoelen)
                {
                    vakC.PlaatsBezoeker(bezoeker);
                }
                else
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
