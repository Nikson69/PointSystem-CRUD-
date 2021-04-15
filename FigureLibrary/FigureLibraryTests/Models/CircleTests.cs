using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            var expectedArea = 1256;

            // act
            var area = figure.Area();

            // assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}