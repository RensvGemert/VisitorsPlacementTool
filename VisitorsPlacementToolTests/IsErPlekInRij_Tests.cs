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
    public class IsErPlekInRij_Tests
    {
        [TestMethod()]
        public void IsErPlekOpDezeRijTest_IsTrue()
        {
            Vak vakA = new Vak("A", 10, 3);
            vakA.aantalBezoekersOpDezeRij = 2;

            bool IsErPlekOpDezeRij = vakA.IsErPlekOpDezeRij();

            Assert.IsTrue(IsErPlekOpDezeRij);
        }

        [TestMethod()]
        public void IsErPlekOpDezeRijTest_IsFalse ()
        {
            Vak vakA = new Vak("A", 10, 3);
            vakA.aantalBezoekersOpDezeRij = 3;

            bool IsErPlekOpDezeRij = vakA.IsErPlekOpDezeRij();

            Assert.IsFalse(IsErPlekOpDezeRij);
        }
    }
}