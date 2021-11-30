using DAL;
using DALInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALFactories
{
    public class BezoekerDALFactory
    {
         public static IBezoekerDAL GetBezoekerDAL()
         {
             return new BezoekerDAL();
         }
    }
}
