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
    public class Evenement_FilterOpTijdAangemeldeBezoekers_Tests
    {
        [TestMethod()]
        public void FilterOpTijdAangemeldeBezoekersTest()
        {
            Organisatie organisatie = new Organisatie("Organisatie");
            List<Vak> vakken = organisatie.MaakVakken();
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken, DateTime.Today);

            List<Bezoeker> TestBezoekers = new List<Bezoeker>();
            TestBezoekers.Add(new Bezoeker("Kind1", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-2)));
            TestBezoekers.Add(new Bezoeker("Kind2", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-2)));
            TestBezoekers.Add(new Bezoeker("Kind3", new DateTime(2014, 2, 2), DateTime.Today.AddDays(1)));

            int expectedResult = 2;
            int result = evenement.FilterOpTijdAangemeldeBezoekers(TestBezoekers).Count;
            Assert.AreEqual(expectedResult, result);
        }
    }
}