using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCollisionDetector.Geometry
{
    public class Rectangle1
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public float? MinX
        {
            get;
            set;
        }
        public float? MaxY
        {
            get;
            set;
        }
        public float? MaxX
        {
            get;
            set;
        }
        public float? MinY
        {
            get;
            set;
        }
        public Rectangle1(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            MinX = x - width / 2;
            MaxY = height / 2 + y;
            MaxX = width / 2 + x;
            MinY = y - height / 2;
          
        }
    }
}
