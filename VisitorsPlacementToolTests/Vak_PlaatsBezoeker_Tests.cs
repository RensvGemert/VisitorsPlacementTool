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
    public class Vak_PlaatsBezoeker_Tests
    {
        [TestMethod()]
        public void PlaatsBezoekerTest()
        {
            Bezoeker bezoeker1 = new Bezoeker("bezoeker01", new DateTime(2015, 1, 1), DateTime.Today);
            Vak vak = new Vak("A", 1, 3);
            vak.PlaatsBezoeker(bezoeker1);

            string expectedResult = "bezoeker01";
            string result = vak.rijen[0].Stoelen[0].Bezoeker.Naam;

            Assert.AreEqual(expectedResult, result);
        }
    }
}