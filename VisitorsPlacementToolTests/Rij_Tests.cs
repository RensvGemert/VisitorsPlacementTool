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
    public class Rij_Tests
    {
        [TestMethod()]
        public void IsErPlekTest_IsTrue()
        {
            Bezoeker bezoeker = new Bezoeker("Rens", new DateTime(1998, 6, 1), DateTime.Today);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("stoel1"));

            Rij rij = new Rij(3, stoelen);

            bool result = rij.IsErPlek(bezoeker);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsErPlekTest_IsFalse()
        {
            Bezoeker testBezoeker = new Bezoeker("TestBezoeker", new DateTime(1998, 6, 1), DateTime.Today);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("stoel1"));
            foreach (var stoel in stoelen)
            {
                stoel.PlaatsBezoeker(testBezoeker);
            }

            Rij rij = new Rij(3, stoelen);

            bool result = rij.IsErPlek(testBezoeker);
            Assert.IsFalse(result);
        }


        [TestMethod()]
        public void PlaatsBezoekerTest_IsTrue()
        {
            // arrange
            Bezoeker bezoeker01 = new Bezoeker("TestBezoeker01", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker02 = new Bezoeker("TestBezoeker02", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker03 = new Bezoeker("TestBezoeker03", new DateTime(2015, 1, 1), DateTime.Today);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("A1-1"));
            stoelen.Add(new Stoel("A1-2"));
            stoelen.Add(new Stoel("A1-3"));
            Rij rij = new Rij(1, stoelen);

            // act
            rij.PlaatsBezoeker(bezoeker01, rij.RijId);
            rij.PlaatsBezoeker(bezoeker02, rij.RijId);
            
            Assert.IsTrue(rij.IsErPlek(bezoeker01));
        }

        [TestMethod()]
        public void PlaatsBezoekerTest_IsFalse()
        {
            // arrange
            Bezoeker bezoeker01 = new Bezoeker("TestBezoeker01", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker02 = new Bezoeker("TestBezoeker02", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker03 = new Bezoeker("TestBezoeker03", new DateTime(2015, 1, 1), DateTime.Today);
            List<Stoel> stoelen = new List<Stoel>();
            stoelen.Add(new Stoel("A1-1"));
            stoelen.Add(new Stoel("A1-2"));
            stoelen.Add(new Stoel("A1-3"));
            Rij rij = new Rij(1, stoelen);

            // act
            rij.PlaatsBezoeker(bezoeker01, rij.RijId);
            rij.PlaatsBezoeker(bezoeker02, rij.RijId);
            rij.PlaatsBezoeker(bezoeker03, rij.RijId);

            Assert.IsFalse(rij.IsErPlek(bezoeker01));
        }
    }
}