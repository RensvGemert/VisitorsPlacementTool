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
            Bezoeker bezoeker1 = new Bezoeker("bezoeker01", 11);
            Bezoeker bezoeker2 = new Bezoeker("bezoeker02", 12);
            Bezoeker bezoeker3 = new Bezoeker("bezoeker03", 11);
           
            Vak vak = new Vak("A", 1, 3);
            vak.PlaatsBezoeker(bezoeker1);
            vak.PlaatsBezoeker(bezoeker2);

            Assert.IsTrue(vak.IsErPlekOpRij1(bezoeker3));
        }

        [TestMethod()]
        public void IsErPlekOpRij1Test_IsFalse()
        {
            Bezoeker bezoeker1 = new Bezoeker("bezoeker01", 23);
            Bezoeker bezoeker2 = new Bezoeker("bezoeker02", 12);
            Bezoeker bezoeker3 = new Bezoeker("bezoeker03", 11);
            Bezoeker bezoeker4 = new Bezoeker("bezoeker03", 22);

            Vak vak = new Vak("A", 1, 3);
            vak.PlaatsBezoeker(bezoeker1);
            vak.PlaatsBezoeker(bezoeker2);
            vak.PlaatsBezoeker(bezoeker3);

            Assert.IsFalse(vak.IsErPlekOpRij1(bezoeker4));
        }
    }
}