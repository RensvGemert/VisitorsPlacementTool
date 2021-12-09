using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DALInterfaces;
using LogicInterfaces;
using DALFactories;

namespace Logic
{
    public class BezoekerLogic : IBezoekerLogic
    {
        private readonly IBezoekerDAL _bezoekerDAL = BezoekerDALFactory.GetBezoekerDAL();

        public List<Bezoeker> GetAllBezoekers()
        {
            return _bezoekerDAL.GetAllBezoekers();
        }
    }
}
