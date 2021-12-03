using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Domain;

namespace DAL
{
    public class BezoekerDAL : IBezoekerDAL
    {
        public List<Bezoeker> GetAllBezoekers()
        {
            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("Kind1", new DateTime(2014, 2, 2), new DateTime(2021, 12, 4)));
            bezoekers.Add(new Bezoeker("Kind2", new DateTime(2014, 2, 2), new DateTime(2031, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind3", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind4", new DateTime(2014, 2, 2), new DateTime(2021, 11, 1)));
            bezoekers.Add(new Bezoeker("Kind5", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind6", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind7", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind8", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind9", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind10", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen1", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen2", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen3", new DateTime(2002, 2, 2), new DateTime(2022, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen4", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen5", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen6", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen7", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen8", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind11", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind12", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind13", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Kind14", new DateTime(2014, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassene9", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen10", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen11", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen12", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen13", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen14", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen15", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            bezoekers.Add(new Bezoeker("Volwassenen16", new DateTime(2002, 2, 2), new DateTime(2021, 12, 2)));
            return bezoekers;
        }
    }
}
