using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Rij
    {
        public int RijId { get; set; }
        public List<Stoel> Stoelen { get; set; }
        public int MaxStoelenPerRij { get; set; }

        public Rij(int rijId, List<Stoel> aantalStoelenPerRij)
        {
            //AantalRijen = aantalRijen;
            RijId = rijId;
            Stoelen = aantalStoelenPerRij;
            MaxStoelenPerRij = aantalStoelenPerRij.Count;
        }

        public bool IsErPlek(Bezoeker bezoeker)
        {
            foreach (var stoel in Stoelen)
            {
                if (stoel.Bezoeker == null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PlaatsBezoeker(Bezoeker bezoeker, int rijId)
        {
            foreach (var stoel in Stoelen)
            {
                if (stoel.Bezoeker == null)
                {
                    if (bezoeker.IsKind() == true && rijId == 1 && stoel.Bezoeker == null)
                    {
                        stoel.PlaatsBezoeker(bezoeker);
                        return true;
                    }
                    else if (bezoeker.IsKind() == false && stoel.Bezoeker == null)
                    {
                        stoel.PlaatsBezoeker(bezoeker);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
