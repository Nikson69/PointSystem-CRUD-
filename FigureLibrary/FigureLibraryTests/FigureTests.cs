using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.Tests
{
    [TestClass()]
    public class FigureTests: Figure
    {
        [TestMethod()]
        public void ExponentiationTest()
        {
            // setup
            var sourse = 20;
            var degree = 2;
            var expectedResult = 400;

            // act
            var result = Exponentiation(sourse, degree);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void SinTest()
        {
            // setup
            var degree = 25;
            var expectedResult = 0.42261826174069944;

            // act
            var result = Sin(degree);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}