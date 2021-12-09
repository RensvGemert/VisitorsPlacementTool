using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Tests
{
    [TestClass()]
    public class Evenement_SorteerBezoekers_Tests
    {
        [TestMethod()]
        public void SorteerBezoekers_Test()
        {
            Organisatie organisatie = new Organisatie("Organisatie");
            List<Vak> vakken = organisatie.MaakVakken();
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken, DateTime.Today);

            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("Kind1", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-6)));
            bezoekers.Add(new Bezoeker("Kind2", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-3)));
            bezoekers.Add(new Bezoeker("Kind3", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-4)));
            bezoekers.Add(new Bezoeker("Kind4", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-15)));
            bezoekers.Add(new Bezoeker("Kind5", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-2)));

            Assert.AreEqual(evenement.SorteerBezoekers(bezoekers)[0].Naam, "Kind4");
        }
    }
}