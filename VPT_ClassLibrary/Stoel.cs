using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Stoel
    {
        public Bezoeker Bezoeker { get; set; }
        public string StoelCode { get; set; }

        public Stoel(string stoelCode)
        {
            StoelCode = stoelCode;
        }

        public void PlaatsBezoeker(Bezoeker bezoeker)
        {
            Bezoeker = bezoeker;
        }
    }
}
