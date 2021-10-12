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
    public class Visitor_Age_Tests
    {
        [TestMethod()]
        public void CheckIfAdultTest_Is_True()
        {
            // arrange
            Visitor visitor = new Visitor("Rens", 13);

            // act
            bool isAdult = visitor.CheckIfAdult();

            // assert
            Assert.IsTrue(isAdult);
        }

        [TestMethod()]
        public void CheckIfAdultTest_Is_False ()
        {
            // arrange
            Visitor visitor = new Visitor("Rens", 12);

            // act
            bool isAdult = visitor.CheckIfAdult();

            // assert
            Assert.IsFalse(isAdult);
        }
    }
}