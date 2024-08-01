using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars.CalculatorKata.ProgramACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeWars.CalculatorKata.ProgramACalculator.Tests
{
    [TestClass()]
    public class PointTests
    {

        [TestMethod()]
        public void GetDistanceFromOriginTest()
        {
            Point point = new Point(3, 4, 0);
            Assert.AreEqual((double)5,point.GetDistanceFromOrigin());
        }

        [TestMethod()]
        public void GetOriginTest()
        {
            Point origin = Point.GetOrigin();
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
            Assert.AreEqual(0, origin.Z);
            Assert.AreEqual(origin.GetType(), typeof(Point));
        }

        [TestMethod()]
        public void GetDistanceFromPointTest()
        {
            Point point1 = new Point(1, 1, 1);
            Point point2 = new Point(4, 5, 1);
            double distance = point1.GetDistanceFromPoint(point2);
            Assert.AreEqual(5, distance);
        }


    }
}