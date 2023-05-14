using GeometryCollisionDetector.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCollisionDetector
{
    public static class CollisionCalculator
    {
        public static bool PointCollisionRectangle(Point1 point, Rectangle1 rectangle)
        {
            if (point.X >= rectangle.MinX && point.X <= rectangle.MaxX &&
                point.Y <= rectangle.MaxY && point.Y >= rectangle.MinY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PointCollisionSphere(Point1 point, Sphere1 sphere)
        {
      
            float deltaX = point.X - sphere.Center.X;
            float deltaY = point.Y - sphere.Center.Y;
            float deltaZ = point.Z - sphere.Center.Z;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            if (distance <= sphere.Radius)
            {
             
                return true;
            }
            else
            {
              
                return false;
            }
        }
        public static bool PointCollisionCircle(Point1 point, Circle1 circle)
        {
            double distance = Math.Sqrt(Math.Pow((point.X - circle.Center.X), 2) + Math.Pow((point.Y - circle.Center.Y), 2)); 
            if (distance <= circle.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PointCollisionCylinder(Point1 point, Cylinder1 cylinder)
        {
            double uzaklikX = point.X - cylinder.Center.X;
            double uzaklikY = point.Y - cylinder.Center.Y;
            double uzaklikZ = point.Z - cylinder.Center.Z;

            double uzaklikDikdortgen = Math.Sqrt(Math.Pow(uzaklikX, 2) + Math.Pow(uzaklikZ, 2));

            if (uzaklikDikdortgen <= cylinder.Radius && uzaklikY >= -cylinder.Height / 2 && uzaklikY <= cylinder.Height / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool RectangleCollisionRectangle(Rectangle1 rect1, Rectangle1 rect2)
        {
            if (rect1.MinX <= rect2.MaxX &&
                rect1.MaxX >= rect2.MinX &&
                rect1.MaxY >= rect2.MinY &&
                rect1.MinY <= rect2.MaxY)
            {

                return true;
            }
            else if (rect2.MinX <= rect1.MaxX &&
                rect2.MaxX >= rect1.MinX &&
                rect2.MaxY >= rect1.MinY &&
                rect2.MinY <= rect1.MaxY)
            {

              
                return true;

            }
            else
            {
               
                return false;
            }
        }
        public static bool PointCollisionRectanglePri(Point1 point, RectanglePri1 prism)
        {
            if (point.X >= prism.MinX && point.X <= prism.MaxX &&
                point.Y >= prism.MinY && point.Y <= prism.MaxY &&
                point.Z >= prism.MinZ && point.Z <= prism.MaxZ)
            {
           
                return true;
            }
            else
            {
                
                return false;
            }
        }
        public static bool RectangleCollisionCircle(Rectangle1 rect, Circle1 circle)
        {

            float circleMaxX = circle.Center.X + circle.Radius;
            float circleMinX = circle.Center.X - circle.Radius;

            float circleMaxY = circle.Center.Y + circle.Radius;
            float circleMinY = circle.Center.Y - circle.Radius;

            bool collisionMaxX = rect.MaxX >= circleMinX;
            bool collisionMinX = rect.MinX <= circleMaxX;

            bool collisionMaxY = rect.MaxY >= circleMinY;
            bool collisionMinY = rect.MinY <= circleMaxY;




            if (collisionMaxX && collisionMinX && collisionMaxY && collisionMaxY)
            {
             
                return true;
            }
            else
            {
            
                return false;
            }
        }
        public static bool CircleCollisionCircle(Circle1 circle1, Circle1 circle2)
        {
            
            float deltaX = circle1.Center.X - circle2.Center.X;
            float deltaY = circle1.Center.Y - circle2.Center.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            
            double radiusSum = circle1.Radius + circle2.Radius;

           
            if (distance < radiusSum)
            {
               
                return true;
            }
            else
            {
                
                return false;
            }
        }
        public static bool SurfaceCollisionSphere(Sphere1 sphere, Surface1 surface)
        {

            Point1 movedsphereposition = sphere.Center + surface.Normal * sphere.Radius;
            float distancefromsurface = Point1.DistanceCalc(movedsphereposition - surface.Center, surface.Normal);
            return distancefromsurface <= 0;
        }
        public static bool SphereCollisionSphere(Sphere1 s1, Sphere1 s2)
        {
            float distance = Point1.DistanceCalc(s1.Center, s2.Center);
            float radiusSum = s1.Radius + s2.Radius;
            return distance <= radiusSum;
        }
        public static bool CylinderCollisionSphere(Sphere1 sphere, Cylinder1 cylinder)
        {

            float distance = Math.Abs(sphere.Center.Y - cylinder.Center.Y);


            if (distance > (cylinder.Height / 2 + sphere.Radius))
            {
                return false;
            }


            float horizontalDistance = Point1.DistanceCalc(
                new Point1() { X = sphere.Center.X, Y = 0, Z = sphere.Center.Z },
              new Point1() { X = cylinder.Center.X, Y = 0, Z = cylinder.Center.Z });


            if (horizontalDistance > cylinder.Radius + sphere.Radius)
            {
                return false;
            }


            return true;
        }
        public static bool SphereCollisionRectanglePri(RectanglePri1 rectPrism, Sphere1 sphere)
        {

            float circleMaxX = sphere.Center.X + sphere.Radius;
            float circleMinX = sphere.Center.X - sphere.Radius;

            float circleMaxY = sphere.Center.Y + sphere.Radius;
            float circleMinY = sphere.Center.Y - sphere.Radius;

            float circleMaxZ = sphere.Center.Z + sphere.Radius;
            float circleMinZ = sphere.Center.X - sphere.Radius;

            bool collisionMaxX = rectPrism.MaxX >= circleMinX;
            bool collisionMinX = rectPrism.MinX <= circleMaxX;

            bool collisionMaxY = rectPrism.MaxY >= circleMinY;
            bool collisionMinY = rectPrism.MinY <= circleMaxY;

            bool collisionMaxZ = rectPrism.MaxZ >= circleMinZ;
            bool collisionMinZ = rectPrism.MinZ <= circleMaxZ;


            if (collisionMaxX && collisionMinX && collisionMaxY && collisionMinY && collisionMaxZ && collisionMinZ)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        public static bool SurfaceCollisionRectanglePri(Surface1 surface, RectanglePri1 prism)
        {
            Point1 maxCorner = new Point1() { X = prism.MaxX, Y = prism.MaxY, Z = prism.MaxZ };
            Point1 minCorner = new Point1() { X = prism.MinX, Y = prism.MinY, Z = prism.MinZ };

            float minProjection = Point1.Dot(minCorner - surface.Center, surface.Normal);
            float maxProjection = Point1.Dot(maxCorner - surface.Center, surface.Normal);


            if (minProjection > 0 && maxProjection > 0)
            {
                return false; 
            }
            else if (minProjection < 0 && maxProjection < 0)
            {
                return false; 
            }
            else
            {
                return true; 
            }

        }
        public static bool RectanglePriCollisionRectanglePri(RectanglePri1 rect1, RectanglePri1 rect2)
        {
            if (rect1.MinX <= rect2.MaxX &&
                rect1.MaxX >= rect2.MinX &&
                rect1.MaxY >= rect2.MinY &&
                rect1.MinY <= rect2.MaxY &&
                rect1.MaxZ >= rect2.MinZ &&
                rect1.MinZ <= rect2.MaxZ
                )
            {

                return true;
            }
            else if (rect2.MinX <= rect1.MaxX &&
                rect2.MaxX >= rect1.MinX &&
                rect2.MaxY >= rect1.MinY &&
                rect2.MinY <= rect1.MaxY &&
                rect2.MaxZ >= rect1.MinZ &&
                rect2.MinZ <= rect1.MaxZ
                )
            {


                return true;

            }
            else
            {

                return false;
            }
        }
        public static bool SurfaceCollisionCylidner(Surface1 surface, Cylinder1 cylinder)
        {
            Point1 movedcylinderposition = cylinder.Center + surface.Normal * cylinder.Radius;
            float distancefromsurface = Point1.DistanceCalc(movedcylinderposition - surface.Center, surface.Normal);
            return distancefromsurface <= 0;
        }
        public static bool CylinderCollisionCylinder(Cylinder1 c1, Cylinder1 c2)
        {
            float distance = Point1.DistanceCalc(c1.Center, c2.Center);
            double radiusSum = c1.Radius + c2.Radius;
            return distance <= radiusSum;
        }

    }
}
