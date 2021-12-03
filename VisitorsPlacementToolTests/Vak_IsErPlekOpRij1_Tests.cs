using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    [TestClass()]
    public class Vak_IsErPlekOpRij1_Tests
    {
        [TestMethod()]
        public void IsErPlekOpRij1Test_IsTrue()
        {
            Bezoeker bezoeker1 = new Bezoeker("bezoeker01", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker2 = new Bezoeker("bezoeker02", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker3 = new Bezoeker("bezoeker03", new DateTime(2015, 1, 1), DateTime.Today);

            Vak vak = new Vak("A", 1, 3);
            vak.PlaatsBezoeker(bezoeker1);
            vak.PlaatsBezoeker(bezoeker2);

            Assert.IsTrue(vak.IsErPlekOpRij1(bezoeker3));
        }

        [TestMethod()]
        public void IsErPlekOpRij1Test_IsFalse()
        {
            Bezoeker bezoeker1 = new Bezoeker("bezoeker01", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker2 = new Bezoeker("bezoeker02", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker3 = new Bezoeker("bezoeker03", new DateTime(2015, 1, 1), DateTime.Today);
            Bezoeker bezoeker4 = new Bezoeker("bezoeker03", new DateTime(2015, 1, 1), DateTime.Today);

            Vak vak = new Vak("A", 1, 3);
            vak.PlaatsBezoeker(bezoeker1);
            vak.PlaatsBezoeker(bezoeker2);
            vak.PlaatsBezoeker(bezoeker3);

            Assert.IsFalse(vak.IsErPlekOpRij1(bezoeker4));
        }
    }
}