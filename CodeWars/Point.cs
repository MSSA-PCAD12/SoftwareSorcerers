using System;


namespace CodeWars
{
    public class Point
    {
        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point GetOrigin()
        {
            return new Point(0,0, 0);
        }

        public double GetDistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public double GetDistanceFromPoint(Point p)
        {

            return Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2) + Math.Pow(p.Z - Z, 2));
        }
    }
}
