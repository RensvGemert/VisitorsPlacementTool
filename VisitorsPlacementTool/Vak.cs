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
        public int AantalRijen { get; set; }
        public int AantalStoelenPerRij { get; set; }


        public Vak()
        {

        }

        public Vak(string vakLetter, int aantalStoelenPerRij)
        {
            VakLetter = vakLetter;
            AantalStoelenPerRij = aantalStoelenPerRij;
        }

        public void MaakRijen(int aantalRijen, int aantalStoelenOpDezeRij)
        {

        }
    }
}
