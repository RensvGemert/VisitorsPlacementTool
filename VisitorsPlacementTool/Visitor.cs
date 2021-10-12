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
        public Visitor(string Name, int Age, int VisitorId)
        {
            this.Name = Name;
            this.Age = Age;
            this.VisitorId = VisitorId;
        }

        public Visitor(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Age check
        public bool CheckIfAdult()
        {
            if (this.Age < MinimumAge)
            {
                Console.WriteLine(this.Name + " is not adult");
                return false;
            }
            else
            {
                Console.WriteLine(this.Name + " is an adult");
                return true;
            }
        }
    }
}
