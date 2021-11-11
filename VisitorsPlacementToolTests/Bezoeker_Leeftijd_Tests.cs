﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorsPlacementTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool.Tests
{
    [TestClass()]
    public class Bezoeker_Leeftijd_Tests
    {
        [TestMethod()]
        public void CheckIsKind_Is_False()
        {
            // arrange
            Bezoeker bezoeker = new Bezoeker("Rens", 13);

            // act
            bool isKind = bezoeker.IsKind();

            // assert
            Assert.IsFalse(isKind);
        }

        [TestMethod()]
        public void CheckIsKind_Is_True()
        {
            // arrange
            Bezoeker bezoeker = new Bezoeker("Rens", 12);

            // act
            bool isKind = bezoeker.IsKind();

            // assert
            Assert.IsTrue(isKind);
        }
    }
}