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
    public class Bezoeker_Leeftijd_Tests
    {
        [TestMethod()]
        public void CheckIsKind_Is_False()
        {
            Bezoeker bezoeker = new Bezoeker("Rens", 13);

            bool isKind = bezoeker.IsKind();

            Assert.IsFalse(isKind);
        }

        [TestMethod()]
        public void CheckIsKind_Is_True()
        {
            Bezoeker bezoeker = new Bezoeker("Rens", 12);

            bool isKind = bezoeker.IsKind();

            Assert.IsTrue(isKind);
        }
    }
}