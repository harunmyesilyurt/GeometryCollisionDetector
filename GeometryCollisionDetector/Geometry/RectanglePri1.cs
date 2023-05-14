using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCollisionDetector.Geometry
{
    public class RectanglePri1
    {
        public Point1 Center { get; set; }
        public Point1 Size { get; set; }
        public float MinX { get; set; }
        public float MaxX { get; set; }
        public float MinY { get; set; }
        public float MaxY { get; set; }
        public float MinZ { get; set; }
        public float MaxZ { get; set; }
        public RectanglePri1(Point1 center, float width, float height, float depth)
        {
            MinX = center.X  - width / 2;
            MinY = height / 2 - center.Y ;
            MinZ = center.Z  - depth / 2;
            MaxX = width / 2 + center.X ;
            MaxY = height / 2 + center.Y ;
            MaxZ = depth / 2 + center.Z ;

        }

    }
}
