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
        public List<Stoel> AantalStoelenPerRij { get; set; }
        public Rij(int aantalRijen, List<Stoel> aantalStoelenPerRij)
        {
            AantalRijen = aantalRijen;
            AantalStoelenPerRij = aantalStoelenPerRij;
        }
    }
}
