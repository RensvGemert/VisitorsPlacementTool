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
    public class Rij_Tests
    {
        [TestMethod()]
        public void IsErPlekTest_IsTrue()
        {
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("stoel1"));

            Rij rij = new Rij(3, stoelen);

            bool result = rij.IsErPlek();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsErPlekTest_IsFalse()
        {
            Bezoeker testBezoeker = new Bezoeker("TestBezoeker", 22);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("stoel1"));
            foreach (var stoel in stoelen)
            {
                stoel.PlaatsBezoeker(testBezoeker);
            }

            Rij rij = new Rij(3, stoelen);

            bool result = rij.IsErPlek();
            Assert.IsFalse(result);
        }
    }
}