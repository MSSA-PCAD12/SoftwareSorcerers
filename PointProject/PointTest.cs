using pointsinPoint;
namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        private static double Epsilon = 1e-6;

        [Test]
        public void ConstructorExampleTest()
        {
            Point point = new Point(5, 0, -2);
            Assert.AreEqual(5, point.X, "Class constructor must assign value of first argument to property \"X\"");
            Assert.AreEqual(0, point.Y, "Class constructor must assign value of first argument to property \"Y\"");
            Assert.AreEqual(-2, point.Z, "Class constructor must assign value of first argument to property \"Z\"");
            point = new Point(1 / 3d, -42 / 27d, 13 / 9d);
            Assert.That(1 / 3d, Is.EqualTo(point.X).Within(Epsilon));
            Assert.That(-42 / 27d, Is.EqualTo(point.Y).Within(Epsilon));
            Assert.That(13 / 9d, Is.EqualTo(point.Z).Within(Epsilon));
        }

        [Test]
        public void GetOriginExampleTest()
        {
            Point origin = Point.GetOrigin();
            Assert.AreEqual(origin.GetType(), typeof(Point), "The origin should be a Point.");
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
            Assert.AreEqual(0, origin.Z);
        }

        [Test]
        public void GetDistanceFromOriginExampleTest()
        {
            Point point = new Point(-3, 5.5, -0.17);
            Assert.That(6.2672880897562065, Is.EqualTo(point.GetDistanceFromOrigin()).Within(Epsilon));
        }

        [Test]
        public void GetDistanceFromPointExampleTest()
        {
            Point point = new Point(3, 4, 5);
            Assert.That(8.137115279846412, Is.EqualTo(point.GetDistanceFromPoint(new Point(-1 / 3d, -55 / 37d, 10))).Within(Epsilon));
        }
    }
}