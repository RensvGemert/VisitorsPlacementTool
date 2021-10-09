using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Visitor
    {
        public string Name;
        public int Age;
        public bool Adult;
        public Visitor(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Age check
        public void CheckIfAdult(Visitor bezoeker)
        {
            if(Age > 12)
            {
                Console.WriteLine(bezoeker.Name + " is an adult");
                bezoeker.Adult = true;
            }
            else
            {
                Console.WriteLine(bezoeker.Name + " is not adult");
                bezoeker.Adult = false;
            }
        }

    }
}
