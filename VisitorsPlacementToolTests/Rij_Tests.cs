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


        [TestMethod()]
        public void PlaatsBezoekerTest_IsTrue()
        {
            // arrange
            Bezoeker bezoeker01 = new Bezoeker("TestBezoeker01", 12);
            Bezoeker bezoeker02 = new Bezoeker("TestBezoeker02", 12);
            Bezoeker bezoeker03 = new Bezoeker("TestBezoeker03", 12);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("A1-1"));
            stoelen.Add(new Stoel("A1-2"));
            stoelen.Add(new Stoel("A1-3"));
            Rij rij = new Rij(1, stoelen);

            // act
            rij.PlaatsBezoeker(bezoeker01);
            rij.PlaatsBezoeker(bezoeker02);
            
            Assert.IsTrue(rij.IsErPlek());
        }

        [TestMethod()]
        public void PlaatsBezoekerTest_IsFalse()
        {
            // arrange
            Bezoeker bezoeker01 = new Bezoeker("TestBezoeker01", 12);
            Bezoeker bezoeker02 = new Bezoeker("TestBezoeker02", 12);
            Bezoeker bezoeker03 = new Bezoeker("TestBezoeker03", 12);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("A1-1"));
            stoelen.Add(new Stoel("A1-2"));
            stoelen.Add(new Stoel("A1-3"));
            Rij rij = new Rij(1, stoelen);

            // act
            rij.PlaatsBezoeker(bezoeker01);
            rij.PlaatsBezoeker(bezoeker02);
            rij.PlaatsBezoeker(bezoeker03);

            Assert.IsFalse(rij.IsErPlek());
        }
    }
}