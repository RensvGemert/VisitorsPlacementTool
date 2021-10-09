using System;

namespace VisitorsPlacementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor("Rens", 11);

            visitor.CheckIfAdult(visitor);
        }
    }
}
