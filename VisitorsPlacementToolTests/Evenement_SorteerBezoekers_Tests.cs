using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    [TestClass()]
    public class Evenement_SorteerBezoekers_Tests
    {
        [TestMethod()]
        public void SorteerBezoekersOpAanmeldDatumTest()
        {
            Organisatie organisatie = new Organisatie("Organisatie");
            List<Vak> vakken = organisatie.MaakVakken();
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken, DateTime.Today);

            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("Kind1", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-1)));
            bezoekers.Add(new Bezoeker("Kind2", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-3)));
            bezoekers.Add(new Bezoeker("Kind3", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-4)));
            bezoekers.Add(new Bezoeker("Kind4", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-5)));
            bezoekers.Add(new Bezoeker("Kind5", new DateTime(2014, 2, 2), DateTime.Today.AddDays(-2)));

            evenement.SorteerBezoekersOpAanmeldDatum(bezoekers);


            Assert.AreEqual(bezoekers[0].Naam, "Kind1");
        }
    }
}