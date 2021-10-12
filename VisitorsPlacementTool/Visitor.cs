using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Visitor
    {
        public int VisitorId;
        public string Name;
        public int Age;
        public int seatNumber;
        public int MinimumAge = 13;

        public Visitor(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Age check
        public bool CheckIfAdult(Visitor visitor)
        {
            if (visitor.Age < MinimumAge)
            {
                Console.WriteLine(visitor.Name + " is not adult");
                return false;
            }
            else
            {
                Console.WriteLine(visitor.Name + " is an adult");
                return true;
            }
        }
    }
}
