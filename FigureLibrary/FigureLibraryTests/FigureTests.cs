using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureLibrary.Tests
{
    [TestClass()]
    public class FigureTests: Figure
    {
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