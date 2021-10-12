using System;
using System.Collections.Generic;
using System.Linq;

namespace VisitorsPlacementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor("Rens", 23);
            Visitor visitor2 = new Visitor("Klaas", 11);
            visitor.CheckIfAdult(visitor);
            visitor2.CheckIfAdult(visitor2);
        }
    }
}
