using System;
using System.Collections.Generic;

namespace VisitorsPlacementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Visitor> allVisitors = new List<Visitor>();
            Visitor visitor = new Visitor();
            Visitor visitor1 = new Visitor("Rens", 23);
            Visitor visitor2 = new Visitor("Henk", 30);
            Visitor visitor3 = new Visitor("Klaas", 12);
            Visitor visitor4 = new Visitor("Piet", 8);

            allVisitors.Add(visitor1);
            allVisitors.Add(visitor2);
            allVisitors.Add(visitor3);
            allVisitors.Add(visitor4);

            foreach(var person in allVisitors)
            {
                person.CheckIfAdult(person);
                person.Register(person);
            }

            visitor.PlaceVisitors(allVisitors);
        }
    }
}
