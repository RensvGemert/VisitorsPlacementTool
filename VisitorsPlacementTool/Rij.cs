using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Rij
    {
        public int AantalRijen { get; set; }
        public List<Stoel> Stoelen { get; set; }
        public int MaxStoelenPerRij { get; set; }

        public Rij(int aantalRijen, List<Stoel> aantalStoelenPerRij)
        {
            AantalRijen = aantalRijen;
            Stoelen = aantalStoelenPerRij;
            MaxStoelenPerRij = aantalStoelenPerRij.Count();
        }
        public bool IsErPlek(Bezoeker bezoeker)
        {
            if (bezoeker.IsKind())
            {
                if(Stoelen.Count <= MaxStoelenPerRij)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                return false;
            }

            foreach (var stoel in Stoelen)
            {
                if (stoel.Bezoeker == null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PlaatsBezoekerInRij(Bezoeker bezoeker)
        {
            foreach (var stoel in Stoelen)
            {
                if(stoel.Bezoeker == null)
                {
                    stoel.PlaatsBezoekerOpStoel(bezoeker);
                    return true;
                }              
            }
            return false;
        }
    }
}

//&& bezoeker.IsKind() != true