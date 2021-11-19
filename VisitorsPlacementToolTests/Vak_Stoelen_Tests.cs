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
    public class Vak_Stoelen_Tests
    {
        [TestMethod()]
        public void BerekenAantalStoelenPerVakTest_AreEqual()
        {
            Vak vak = new Vak("A", 3, 5);           

            int resultaat = vak.BerekenAantalStoelenPerVak(3, 5);
            int verwachtResultaat = 15;
            Assert.AreEqual(verwachtResultaat, resultaat);
        }
    }
}