using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibrary.Models.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleWithGivenAngle()
        {
            // setup
            double firstSides = 5;
            double secondSides = 10;
            double degree = 123;
            var figure = new Triangle(firstSides, secondSides, degree);
            var expectedArea = 20.9667641986356;

            // act
            var area = figure.Area();

            // assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod()]
        public void TriangleWithGivenAngle90degrees()
        {
            // setup
            double firstSides = 5;
            double secondSides = 10;
            double degree = 90;
            var figure = new Triangle(firstSides, secondSides, degree);
            var expectedArea = 25;

            // act
            var area = figure.Area();

            // assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod()]
        public void TriangleWithGivenHeight()
        {
            // setup
            double side = 5;
            double height = 10;
            var figure = new Triangle(side, height);
            var expectedArea = 25;

            // act
            var area = figure.Area();

            // assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod()]
        public void TriangleWithEqualSides()
        {
            // setup
            double side = 5;
            var figure = new Triangle(side);
            var expectedArea = 10.825317547305483;

            // act
            var area = figure.Area();

            // assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}