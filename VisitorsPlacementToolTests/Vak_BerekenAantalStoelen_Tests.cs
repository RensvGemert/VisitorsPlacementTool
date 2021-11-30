using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace UI.Tests
{
    [TestClass()]
    public class Vak_BerekenAantalStoelen_Tests
    {
        [TestMethod()]
        public void BerekenAantalStoelenPerVakTest_AreEqual()
        {
            Vak vak = new Vak("A", 3, 5);           

            int resultaat = vak.TotaalAantalStoelen;
            int verwachtResultaat = 15;
            Assert.AreEqual(verwachtResultaat, resultaat);
        }
    }
}