using Logic;
using LogicInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicFactories
{
    public class BezoekerLogicFactory
    {
        public static IBezoekerLogic GetBezoekerLogic()
        {
            return new BezoekerLogic();
        }
    }
}
