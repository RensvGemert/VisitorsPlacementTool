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
    public class Organisatie_Tests
    {
        [TestMethod()]
        public void GeefAangemeldeBezoekersEenIdTest()
        {
            Organisatie organisatie = new Organisatie("TestOrganisatie");

            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("Rens", DateTime.Now, DateTime.Today.AddDays(-1)));
            bezoekers.Add(new Bezoeker("Klaas", DateTime.Now, DateTime.Today.AddDays(-1)));
            bezoekers.Add(new Bezoeker("Henk", DateTime.Now, DateTime.Today.AddDays(-1)));

            organisatie.GeefAangemeldeBezoekersEenId(bezoekers);
        
            Assert.AreEqual(2, bezoekers[1].Id);
        }
    }
}