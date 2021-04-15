using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary.Models;

namespace FigureServices.Tests
{
    [TestClass()]
    public class AreaСalculationsTests
    {
        [TestMethod()]
        public void AreaСalculationsForTriangle()
        {
            // setup
            double side = 5;
            var figure = new Triangle(side);
            var areaСalculations = new AreaСalculations(figure);
            var expectedArea = 10.825317547305483;

            // act
            var area = areaСalculations.GetArea();

            // assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod()]
        public void AreaСalculationsForCircle()
        {
            // setup
            var radius = 20;
            var figure = new Circle(radius);
            var areaСalculations = new AreaСalculations(figure);
            var expectedArea = 1256.6370614359173;

            // act
            var area = areaСalculations.GetArea();

            // assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}