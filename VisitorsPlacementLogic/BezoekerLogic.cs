using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorsPlacementDAL;

namespace VisitorsPlacementLogic
{
    public class BezoekerLogic
    {
        private readonly BezoekerDAL _bezoekerDAL;
        public BezoekerLogic(BezoekerDAL bezoekerDAL)
        {
            _bezoekerDAL = bezoekerDAL;
        }

        public List<Bezoeker> MaakBezoekerTestData()
        {
            return _bezoekerDAL.MaakBezoekerTestData();
        }
    }
}
