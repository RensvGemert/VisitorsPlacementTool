using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALInterfaces
{
    public interface IBezoekerDAL
    {
        public List<Bezoeker> GetAllBezoekers();
    }
}
