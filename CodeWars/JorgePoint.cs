
namespace Pointsin3DSpace
{
    public class Point
    {
        public double X { get; set; }
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
            return new Point(0, 0, 0);
        }
        public double GetDistanceFromOrigin()
        {

            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public double GetDistanceFromPoint(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            double dz = Z - other.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }


    }
}
