//using NUnit.Framework;
using System;
namespace CodeWars
{
    [TestClass()]

    public class SolutionTest
    {
        private static double Epsilon = 1e-6;

        [TestMethod]
        public void ConstructorExampleTest()
        {
            Point point = new Point(5, 0, -2);
            Assert.AreEqual(5, point.X, "Class constructor must assign value of first argument to property \"X\"");
            Assert.AreEqual(0, point.Y, "Class constructor must assign value of first argument to property \"Y\"");
            Assert.AreEqual(-2, point.Z, "Class constructor must assign value of first argument to property \"Z\"");
            //point = new Point(1 / 3d, -42 / 27d, 13 / 9d);
            //Assert.That(1 / 3d, Is.EqualTo(point.X).Within(Epsilon));
            //Assert.That(-42 / 27d, Is.EqualTo(point.Y).Within(Epsilon));
            //Assert.That(13 / 9d, Is.EqualTo(point.Z).Within(Epsilon));

        }
        [TestMethod]
        public void GetOriginExampleTest()
        {
            Point origin = Point.GetOrigin();
            Assert.AreEqual(origin.GetType(), typeof(Point), "The origin should be a Point.");
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
            Assert.AreEqual(0, origin.Z);
        }

        [TestMethod]
        public void GetDistanceFromOriginExampleTest()
        {
            Point point = new Point(3, 4, 0);
            Assert.AreEqual((double)5, point.GetDistanceFromOrigin());
        }

        [TestMethod]
        public void GetDistanceFromPointExampleTest()
        {
             Point point1 = new Point(1, 1, 1);
            Point point2 = new Point(4, 5, 1);
            double distance = point1.GetDistanceFromPoint(point2);
            Assert.AreEqual(5, distance);
        }
    }
}