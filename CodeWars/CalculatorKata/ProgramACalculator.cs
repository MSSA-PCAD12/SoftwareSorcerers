using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.CalculatorKata
{
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Point(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public double GetDistanceFromOrigin()
            {
                Point origin = Point.GetOrigin();
                return GetDistanceFromPoint(origin);
            }

            public static Point GetOrigin() => new Point(0, 0, 0);

            public double GetDistanceFromPoint(Point inputPoint)
            {
                double distanceX = inputPoint.X - X;
                double distanceY = inputPoint.Y - Y;
                double distanceZ = inputPoint.Z - Z;

                return Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
            }
        }

    }

