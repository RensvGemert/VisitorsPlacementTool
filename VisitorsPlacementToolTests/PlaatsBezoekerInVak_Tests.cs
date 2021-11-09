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
    public class PlaatsBezoekerInVak_Tests
    {
        [TestMethod()]
        public void PlaatsBezoekerInVakTest_AreEqual()
        {
            Bezoeker bezoeker = new Bezoeker("bezoeker01", 13);
            Vak vak = new Vak("A", 5, 10);

            vak.PlaatsBezoekerInVak(bezoeker);
            int aantalPlekkenBezet = vak.huidigAantalPlekkenInVak;

            Assert.AreEqual(aantalPlekkenBezet, 1);
        }

        [TestMethod()]
        public void PlaatsBezoekerInVakTest_AreNotEqual()
        {
            Bezoeker bezoeker = new Bezoeker("bezoeker01", 13);
            Vak vak = new Vak("A", 5, 10);

            vak.PlaatsBezoekerInVak(bezoeker);
            vak.PlaatsBezoekerInVak(bezoeker);
            int aantalPlekkenBezet = vak.huidigAantalPlekkenInVak;

            Assert.AreNotEqual(aantalPlekkenBezet, 1);
        }
    }
}