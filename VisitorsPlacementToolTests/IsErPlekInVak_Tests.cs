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
    public class IsErPlekInVak_Tests
    {
        [TestMethod()]
        public void IsErPlekInVakTest_IsTrue()
        {
            Vak vak = new Vak("B", 5, 5);

            bool IsErPlek = vak.IsErPlekInVak();
            Assert.IsTrue(IsErPlek);
        }

        [TestMethod()]
        public void IsErPlekInVakTest_IsFalse()
        {
            Vak vak = new Vak("B", 5, 5);
            vak.huidigAantalPlekkenInVak = 5;

            bool IsErPlek = vak.IsErPlekInVak();
            Assert.IsFalse(IsErPlek);
        }
    }
}