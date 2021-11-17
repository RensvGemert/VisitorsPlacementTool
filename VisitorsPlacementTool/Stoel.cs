using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Stoel
    {
        public Bezoeker Bezoeker { get; set; }
        public string StoelCode { get; set; }

        public Stoel(string stoelCode)
        {
            StoelCode = stoelCode;
        }

        public void PlaatsBezoekerOpStoel(Bezoeker bezoeker)
        {
            Bezoeker = bezoeker;
        }

        //public override string ToString()
        //{
        //    if (Bezoeker != null)
        //    {
        //        return StoelCode + " " + Bezoeker.Naam + " Leeftijd: " + Bezoeker.Leeftijd;
        //    }
        //    else
        //    {
        //        return StoelCode;
        //    }
        //}
    }
}
