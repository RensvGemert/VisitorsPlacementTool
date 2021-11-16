using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Rij
    {
        public int RijId { get; set; }
        public int AantalRijen { get; set; }
        public List<Stoel> Stoelen { get; set; }
        public Rij(int aantalRijen, List<Stoel> aantalStoelenPerRij)
        {
            AantalRijen = aantalRijen;
            Stoelen = aantalStoelenPerRij;
        }

        public void PlaatsBezoeker(Bezoeker bezoeker)
        {
            for (int i = 0; i < Stoelen.Count(); i++)
            {
                Stoelen[i].PlaatsBezoeker(bezoeker);
            }
        }
    }
}
