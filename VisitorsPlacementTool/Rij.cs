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

        public Rij(int aantalRijen, List<Stoel> aantalStoelenPerRij)
        {
            AantalRijen = aantalRijen;
            Stoelen = aantalStoelenPerRij;
        }
        public bool IsErPlek(Bezoeker bezoeker)
        {
            // Als bezoeker een kind is
            // To Do: Check of er plek is op Rij 1 
            if (bezoeker.IsKind())
            {
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