using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorsPlacementTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool.Tests
{
    [TestClass()]
    public class Evenement_Tests
    {
        [TestMethod()]
        public void BerekenMaxAantalBezoekersTest_AreEqual()
        {
            List<Vak> vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 5);
            Vak vakB = new Vak("B", 3, 5);
            vakken.Add(vakA);
            vakken.Add(vakB);

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            int verwachtResultaat = 30;
            int resultaat = evenement.BerekenMaxAantalBezoekers(vakken);

            Assert.AreEqual(verwachtResultaat, resultaat);
        }

        [TestMethod()]
        public void BerekenMaxAantalBezoekersTest_AreNotEqual()
        {
            List<Vak> vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 5);
            Vak vakB = new Vak("B", 1, 4);
            vakken.Add(vakA);
            vakken.Add(vakB);

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            int foutResultaat = 1;
            int resultaat = evenement.BerekenMaxAantalBezoekers(vakken);

            Assert.AreNotEqual(foutResultaat, resultaat);
        }
    }
}