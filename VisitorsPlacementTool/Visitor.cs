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
        public bool IsAdult;
        public int seatNumber;
        public int MinimumAge = 13;
        public Visitor()
        {

        }

        public Visitor(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Age check
        public void CheckIfAdult(Visitor visitor)
        {
            if (visitor.Age < MinimumAge)
            {
                Console.WriteLine(visitor.Name + " is not adult");
                visitor.IsAdult = false;
            }
            else
            {
                Console.WriteLine(visitor.Name + " is an adult");
                visitor.IsAdult = true;
            }
        }

        // Register visitor
        public void Register(Visitor visitor)
        {
            List<Visitor> RegisteredVisitors = new List<Visitor>();
            RegisteredVisitors.Add(visitor);
            Console.WriteLine(visitor.Name + " is succesfully registered \n");
        }

        // Give seat number
        public bool PlaceVisitors(List<Visitor> ListOfAllVisitors)
        {
            foreach (var visitor in ListOfAllVisitors)
            {
                seatNumber++;
                Console.WriteLine(visitor.Name + " has given seat number " + seatNumber);
            }
            return true;
        }
    }
}
