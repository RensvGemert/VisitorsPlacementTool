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
            MaxStoelenPerRij = aantalStoelenPerRij.Count;
        }

        public bool IsErPlek()
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

        public bool IsErPlekOpRij1()
        {
             if (AantalRijen > 0 && AantalRijen < 2)
             {
                  foreach (var stoel in Stoelen)
                  {
                      if(stoel.Bezoeker == null)
                      {
                          return true;
                      }
                  }
             }               
            return false;
        }

        public bool PlaatsBezoeker(Bezoeker bezoeker)
        {
            foreach (var stoel in Stoelen)
            {
                if (bezoeker.IsKind() == true && IsErPlekOpRij1() == true)
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
            return false;
        }
    }
}