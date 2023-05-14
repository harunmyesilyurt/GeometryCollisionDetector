using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCollisionDetector.Geometry
{
    public class Point1
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public static float Dot(Point1 a, Point1 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        public static Point1 operator + (Point1 p1, Point1 p2)
        {
            return new Point1()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y,
                Z = p1.Z + p2.Z,
            };
        }

        public static Point1 operator - (Point1 p1, Point1 p2)
        {
            return new Point1()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y,
                Z = p1.Z - p2.Z,
            };
        }

        public static Point1 operator * (Point1 p, float scalar)
        {
            return new Point1()
            {
                X = p.X * scalar,
                Y = p.Y * scalar,
                Z = p.Z * scalar,
            };
        }
        public static float DistanceCalc(Point1 p1, Point1 p2)
        {
            float dx = p1.X - p2.X;
            float dY = p1.Y - p2.Y;
            float dZ = p1.Z - p2.Z;
            return (float)Math.Sqrt(dx * dx + dY * dY + dZ * dZ);
        }
    }
}
