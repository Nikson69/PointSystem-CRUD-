using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibrary.Models.Tests
{
    [TestClass()]
    public class CircleTests
    {        
        [TestMethod()]
        public void AreaTest()
        {
            // setup
            var radius = 20;
            var figure = new Circle(radius);
            var expectedArea = 1256.6370614359173;

            // act
            var area = figure.Area();

            // assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}