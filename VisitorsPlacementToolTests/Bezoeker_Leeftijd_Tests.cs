using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace UI.Tests
{
    [TestClass()]
    public class Bezoeker_Leeftijd_Tests
    {
        [TestMethod()]
        public void CheckIsKind_Is_False()
        {
            Bezoeker bezoeker = new Bezoeker("Rens", new DateTime(1998, 6, 1), DateTime.Today);

            bool isKind = bezoeker.IsKind();

            Assert.IsFalse(isKind);
        }

        [TestMethod()]
        public void CheckIsKind_Is_True()
        {
            Bezoeker bezoeker = new Bezoeker("Rens", new DateTime(2015, 1, 1), DateTime.Today);

            bool isKind = bezoeker.IsKind();

            Assert.IsTrue(isKind);
        }
    }
}