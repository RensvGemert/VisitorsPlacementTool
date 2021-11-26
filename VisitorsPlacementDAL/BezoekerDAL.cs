using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace VisitorsPlacementDAL
{
    public class BezoekerDAL
    {
        public List<Bezoeker> MaakBezoekerTestData()
        {
            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("Kind1", 11));
            bezoekers.Add(new Bezoeker("Kind2", 11));
            bezoekers.Add(new Bezoeker("Kind3", 11));
            bezoekers.Add(new Bezoeker("Kind4", 11));
            bezoekers.Add(new Bezoeker("Kind5", 11));
            bezoekers.Add(new Bezoeker("Kind6", 11));
            bezoekers.Add(new Bezoeker("Kind7", 11));
            bezoekers.Add(new Bezoeker("Kind8", 11));
            bezoekers.Add(new Bezoeker("Kind9", 11));
            bezoekers.Add(new Bezoeker("Kind10", 11));
            bezoekers.Add(new Bezoeker("Volwassenen1", 22));
            bezoekers.Add(new Bezoeker("Volwassenen2", 22));
            bezoekers.Add(new Bezoeker("Volwassenen3", 22));
            bezoekers.Add(new Bezoeker("Volwassenen4", 22));
            bezoekers.Add(new Bezoeker("Volwassenen5", 22));
            bezoekers.Add(new Bezoeker("Volwassenen6", 22));
            bezoekers.Add(new Bezoeker("Volwassenen7", 22));
            bezoekers.Add(new Bezoeker("Volwassenen8", 22));
            bezoekers.Add(new Bezoeker("Kind11", 11));
            bezoekers.Add(new Bezoeker("Kind12", 11));
            bezoekers.Add(new Bezoeker("Kind13", 11));
            bezoekers.Add(new Bezoeker("Kind14", 11));
            bezoekers.Add(new Bezoeker("Volwassene9", 22));
            bezoekers.Add(new Bezoeker("Volwassenen10", 22));
            bezoekers.Add(new Bezoeker("Volwassenen11", 22));
            bezoekers.Add(new Bezoeker("Volwassenen12", 22));
            bezoekers.Add(new Bezoeker("Volwassenen13", 22));
            bezoekers.Add(new Bezoeker("Volwassenen14", 22));
            bezoekers.Add(new Bezoeker("Volwassenen15", 22));
            bezoekers.Add(new Bezoeker("Volwassenen16", 22));
            bezoekers.Add(new Bezoeker("Volwassenen17", 22));
            bezoekers.Add(new Bezoeker("Volwassenen18", 22));
            bezoekers.Add(new Bezoeker("Volwassenen19", 22));
            bezoekers.Add(new Bezoeker("Volwassenen20", 22));
            bezoekers.Add(new Bezoeker("Volwassenen21", 22));
            return bezoekers;
        }
    }
}
