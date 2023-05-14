using GeometryCollisionDetector.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GeometryCollisionDetector
{
    public partial class Form1 : Form
    {
        TextBox X1, X2,
                Y1, Y2,
                Z1, Z2,
                Height1, Height2,
                Width1, Width2,
                Depth1, Depth2,
                Radius1, Radius2,
                NormalX1, NormalX2,
                NormalY1, NormalY2,
                NormalZ1, NormalZ2;


        Label LabelX,
              LabelY,
              LabelZ,
              LabelHeight,
              LabelWidth,
              LabelDepth,
              LabelRadius,
              LabelNormalX,
              LabelNormalY,
              LabelNormalZ;


        private void Button1_Click(object sender, EventArgs e)
        {
            string Choose = $"{SelectGeometry1.SelectedItem.ToString()}-{SelectGeometry2.SelectedItem.ToString()}";
            Point1 point;
            Rectangle1 rectangle, rectangle2;
            Sphere1 sphere, sphere2;
            Circle1 circle, circle2;
            RectanglePri1 rectangularPrism, rectangularPrism2;
            Cylinder1 cylinder, cylinder2;
            Surface1 surface;
            bool Result;
            switch (Choose)
            {

                case "Point-Rectangle":
                    point = new Point1() { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) };
                    rectangle = new Rectangle1(float.Parse(X2.Text), float.Parse(Y2.Text), float.Parse(Width2.Text), float.Parse(Height2.Text));
                    Result = CollisionCalculator.PointCollisionRectangle(point, rectangle);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Point-Sphere":
                    point = new Point1() { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) };
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.PointCollisionSphere(point, sphere);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Point-Circle":
                    point = new Point1() { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) };
                    circle = new Circle1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.PointCollisionCircle(point, circle);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Point-Cylinder":
                    point = new Point1() { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) };
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text), Height = float.Parse(Height2.Text) };
                    Result = CollisionCalculator.PointCollisionCylinder(point, cylinder);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Point-RectangularPrism":
                    point = new Point1() { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) };
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, float.Parse(Width2.Text), float.Parse(Height2.Text), float.Parse(Depth2.Text));
                    Result = CollisionCalculator.PointCollisionRectanglePri(point, rectangularPrism);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Rectangle-Point":
                    rectangle = new Rectangle1(float.Parse(X1.Text), float.Parse(Y1.Text), float.Parse(Width1.Text), float.Parse(Height1.Text));
                    point = new Point1() { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) };
                    Result = CollisionCalculator.PointCollisionRectangle(point, rectangle);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Rectangle-Rectangle":
                    rectangle = new Rectangle1(float.Parse(X1.Text), float.Parse(Y1.Text), float.Parse(Width1.Text), float.Parse(Height1.Text));
                    rectangle2 = new Rectangle1(float.Parse(X2.Text), float.Parse(Y2.Text), float.Parse(Width2.Text), float.Parse(Height2.Text));
                    Result = CollisionCalculator.RectangleCollisionRectangle(rectangle, rectangle2);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Rectangle-Circle":
                    rectangle = new Rectangle1(float.Parse(X1.Text), float.Parse(Y1.Text), float.Parse(Width1.Text), float.Parse(Height1.Text));
                    circle = new Circle1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.RectangleCollisionCircle(rectangle, circle);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                case "Circle-Rectangle":
                    circle = new Circle1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    rectangle = new Rectangle1(float.Parse(X2.Text), float.Parse(Y2.Text), float.Parse(Width2.Text), float.Parse(Height2.Text));
                    Result = CollisionCalculator.RectangleCollisionRectangle(rectangle, rectangle);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Circle-Point":
                    circle = new Circle1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    point = new Point1() { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) };
                    Result = CollisionCalculator.PointCollisionCircle(point, circle);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Circle-Circle":
                    circle = new Circle1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    circle2 = new Circle1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.CircleCollisionCircle(circle, circle2);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Sphere-Surface":
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    surface = new Surface1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Normal = new Point1 { X = Convert.ToUInt32(NormalX2.Text), Y = Convert.ToUInt32(NormalY2.Text), Z = Convert.ToUInt32(NormalZ2.Text) } };
                    Result = CollisionCalculator.SurfaceCollisionSphere(sphere, surface);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                case "Sphere-Sphere":
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    sphere2 = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.SphereCollisionSphere(sphere, sphere2);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                case "Sphere-Cylinder":
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text), Height = float.Parse(Height2.Text) };
                    Result = CollisionCalculator.CylinderCollisionSphere(sphere, cylinder);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Sphere-RectangularPrism":
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, float.Parse(Width2.Text), float.Parse(Height2.Text), float.Parse(Depth2.Text));
                    Result = CollisionCalculator.SphereCollisionRectanglePri(rectangularPrism, sphere);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Sphere-Point":
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text) };
                    point = new Point1() { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) };
                    Result = CollisionCalculator.PointCollisionSphere(point, sphere);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "RectangularPrism-Point":
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, float.Parse(Width1.Text), float.Parse(Height1.Text), float.Parse(Depth1.Text));
                    point = new Point1() { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) };
                    Result = CollisionCalculator.PointCollisionRectanglePri(point, rectangularPrism);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                case "RectangularPrism-Surface":
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, float.Parse(Width1.Text), float.Parse(Height1.Text), float.Parse(Depth1.Text));
                    surface = new Surface1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Normal = new Point1 { X = Convert.ToUInt32(NormalX2.Text), Y = Convert.ToUInt32(NormalY2.Text), Z = Convert.ToUInt32(NormalZ2.Text) } };
                    Result = CollisionCalculator.SurfaceCollisionRectanglePri(surface, rectangularPrism);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                case "RectangularPrism-Sphere":
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, float.Parse(Width1.Text), float.Parse(Height1.Text), float.Parse(Depth1.Text));
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.SphereCollisionRectanglePri(rectangularPrism, sphere);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "RectangularPrism-RectangularPrism":
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, float.Parse(Width1.Text), float.Parse(Height1.Text), float.Parse(Depth1.Text));
                    rectangularPrism2 = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, float.Parse(Width2.Text), float.Parse(Height2.Text), float.Parse(Depth2.Text));
                    Result = CollisionCalculator.RectanglePriCollisionRectanglePri(rectangularPrism, rectangularPrism2);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                case "Cylinder-Point":
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text), Height = float.Parse(Height1.Text) };
                    point = new Point1() { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) };
                    Result = CollisionCalculator.PointCollisionCylinder(point, cylinder);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Cylinder-Sphere":
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text), Height = float.Parse(Height1.Text) };
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.CylinderCollisionSphere(sphere, cylinder);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Cylinder-Surface":
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text), Height = float.Parse(Height1.Text) };
                    surface = new Surface1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Normal = new Point1 { X = Convert.ToUInt32(NormalX2.Text), Y = Convert.ToUInt32(NormalY2.Text), Z = Convert.ToUInt32(NormalZ2.Text) } };
                    Result = CollisionCalculator.SurfaceCollisionCylidner(surface, cylinder);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Cylinder-Cylinder":
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Radius = float.Parse(Radius1.Text), Height = float.Parse(Height1.Text) };
                    cylinder2 = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text), Height = float.Parse(Height2.Text) };
                    Result = CollisionCalculator.CylinderCollisionCylinder(cylinder, cylinder2);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Surface-RectangularPrism":
                    surface = new Surface1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Normal = new Point1 { X = Convert.ToUInt32(NormalX1.Text), Y = Convert.ToUInt32(NormalY1.Text), Z = Convert.ToUInt32(NormalZ1.Text) } };
                    rectangularPrism = new RectanglePri1(new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, float.Parse(Width2.Text), float.Parse(Height2.Text), float.Parse(Depth2.Text));
                    Result = CollisionCalculator.SurfaceCollisionRectanglePri(surface, rectangularPrism);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Surface-Sphere":
                    surface = new Surface1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Normal = new Point1 { X = Convert.ToUInt32(NormalX1.Text), Y = Convert.ToUInt32(NormalY1.Text), Z = Convert.ToUInt32(NormalZ1.Text) } };
                    sphere = new Sphere1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text) };
                    Result = CollisionCalculator.SurfaceCollisionSphere(sphere, surface);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;
                case "Surface-Cylinder":
                    surface = new Surface1() { Center = new Point1 { X = Convert.ToUInt32(X1.Text), Y = Convert.ToUInt32(Y1.Text), Z = Convert.ToUInt32(Z1.Text) }, Normal = new Point1 { X = Convert.ToUInt32(NormalX1.Text), Y = Convert.ToUInt32(NormalY1.Text), Z = Convert.ToUInt32(NormalZ1.Text) } };
                    cylinder = new Cylinder1() { Center = new Point1 { X = Convert.ToUInt32(X2.Text), Y = Convert.ToUInt32(Y2.Text), Z = Convert.ToUInt32(Z2.Text) }, Radius = float.Parse(Radius2.Text), Height = float.Parse(Height2.Text) };
                    Result = CollisionCalculator.SurfaceCollisionCylidner(surface, cylinder);
                    ResultBox1.Items.Add(Result ? "Cisimler Çarpışır" : "Cisimler Çarpışmaz");
                    break;

                default:

                    break;
            }
        }
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectGeometry1.Focus();
        }

        #region Events
        private void SelectGeometry1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectGeometry1.SelectedItem.ToString())
            {
                case "Point":
                    PageMakingReady(new[] { "Rectangle", "Sphere", "Circle", "Cylinder", "RectangularPrism" });
                    break;

                case "Rectangle":
                    PageMakingReady(new[] { "Point", "Rectangle", "Circle" });
                    break;

                case "Circle":
                    PageMakingReady(new[] { "Rectangle", "Point", "Circle" });
                    break;

                case "Sphere":
                    PageMakingReady(new[] { "Surface", "Sphere", "Cylinder", "RectangularPrism", "Point" });
                    break;

                case "RectangularPrism":
                    PageMakingReady(new[] { "Point", "Surface", "Sphere", "RectangularPrism" });
                    break;

                case "Cylinder":
                    PageMakingReady(new[] { "Point", "Sphere", "Surface", "Cylinder" });
                    break;

                case "Surface":
                    PageMakingReady(new[] { "RectangularPrism", "Sphere", "Cylinder" });
                    break;

                default:
                    GeometryPanel1.Refresh();
                    SelectGeometry2.Items.Clear();
                    SelectGeometry2.ResetText();
                    SelectGeometry2.SelectedIndex = -1;
                    InputPanel1.Controls.Clear();
                    InputPanel2.Controls.Clear();

                    break;
            }
            Configurations1(SelectGeometry1.SelectedItem.ToString(), InputPanel1);
        }
        private void SelectGeometry2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeometryPanel2.Refresh();
            InputPanel2.Controls.Clear();
            Configurations2(SelectGeometry2.SelectedItem.ToString(), InputPanel2);

        }
        #endregion

        #region Helpers
        private void PageMakingReady(string[] elements)
        {
            GeometryPanel1.Refresh();
            SelectGeometry2.Items.Clear();
            SelectGeometry2.ResetText();
            SelectGeometry2.SelectedIndex = -1;
            InputPanel2.Controls.Clear();
            InputPanel1.Controls.Clear();

            for (int i = 0; i < elements.Length; i++)
            {
                SelectGeometry2.Items.Add(elements[i]);
            }

        }

        private void Pointer(TextBox textBox, Label label, int tX, int tY, int lX, int lY)
        {
            textBox.Location = new Point(tX, tY);
            label.Location = new Point(lX, lY);
        }
        #endregion

        #region Paint
        void CircleD(PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.Blue, 3);

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(80, 70, 30, 30);

            e.Graphics.DrawEllipse(bluePen, rect);
        }

        void PointD(PaintEventArgs e)
        {
            SolidBrush bluePen = new SolidBrush(Color.Blue);

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(90, 80, 10, 10);

            e.Graphics.FillEllipse(bluePen, rect);
        }

        void RectangleD(PaintEventArgs e)
        {

            Pen bluePen = new Pen(Color.Blue, 3);

            Rectangle rect = new Rectangle(70, 70, 50, 40);

            e.Graphics.DrawRectangle(bluePen, rect);
        }

        void SphereD(PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.Blue);

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(60, 60, 60, 60);
            System.Drawing.Rectangle rectShadow = new System.Drawing.Rectangle(60, 80, 60, 20);

            e.Graphics.DrawEllipse(bluePen, rectShadow);
            e.Graphics.DrawEllipse(bluePen, rect);
        }

        void SurfaceD(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue);
            Pen Redpen = new Pen(Color.Red);
            // Dikdörtgenin sol yüzü
            Point[] line = new Point[] {
                  new Point(80, 80),
                  new Point(130, 130),
                  new Point(180 ,80 ),
                  new Point(130, 50),

              };
            Point[] normal = new Point[] { new Point(130, 80), new Point(100, 10) };

            g.DrawPolygon(pen, line);
            g.DrawPolygon(Redpen, normal);
        }

        void CylinderD(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);



            // Silindirin alt çiz
            Rectangle bottom = new Rectangle(50, 100, 100, 50);
            graphics.DrawEllipse(pen, bottom);

            // Silindirin üstünü çiz
            Rectangle top = new Rectangle(50, 25, 100, 50);
            graphics.DrawEllipse(pen, top);
            graphics.DrawLine(pen, 50, 55, 50, 130);
            graphics.DrawLine(pen, 150, 55, 150, 130);


        }

        void RectanglePriD(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen bluePen = new Pen(Color.Blue, 2);

            Point[] leftFace = new Point[] {
                  new Point(50, 50),
                  new Point(100, 50),
                  new Point(100, 125),
                  new Point(50, 125)
              };
            g.DrawPolygon(bluePen, leftFace);

            Point[] rightFace = new Point[] {
                  new Point(100, 50),
                  new Point(150, 25),
                  new Point(150, 100),
                  new Point(100, 125)
                 };
            g.DrawPolygon(bluePen, rightFace);

            Point[] topFace = new Point[] {
                  new Point(50, 50),
                  new Point(100, 50),
                  new Point(147, 25),
                  new Point(100, 25)
                 };
            g.DrawPolygon(bluePen, topFace);

        }
        void Print(ComboBox comboBox, PaintEventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Point":
                    PointD(e);
                    break;

                case "Rectangle":
                    RectangleD(e);
                    break;

                case "Circle":
                    CircleD(e);
                    break;

                case "Sphere":
                    SphereD(e);
                    break;

                case "RectangularPrism":
                    RectanglePriD(e);
                    break;

                case "Cylinder":
                    CylinderD(e);
                    break;

                case "Surface":
                    SurfaceD(e);
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Printers

        private void GeometryPanel1_Paint(object sender, PaintEventArgs e)
        {
            Print(SelectGeometry1, e);
        }

        private void GeometryPanel2_Paint(object sender, PaintEventArgs e)
        {
            Print(SelectGeometry2, e);
        }
        #endregion


        private void Configurations1(string type, Panel panel)
        {
            X1 = new TextBox();
            LabelX = new Label();
            LabelX.Text = "X";

            Y1 = new TextBox();
            LabelY = new Label();
            LabelY.Text = "Y";

            Z1 = new TextBox();
            LabelZ = new Label();
            LabelZ.Text = "Z";

            Height1 = new TextBox();
            LabelHeight = new Label { Text = "Height" };

            Width1 = new TextBox();
            LabelWidth = new Label { Text = "Weight" };

            Depth1 = new TextBox();
            LabelDepth = new Label { Text = "Depth" };

            Radius1 = new TextBox();
            LabelRadius = new Label { Text = "Radius" };

            NormalX1 = new TextBox();
            LabelNormalX = new Label { Text = "NormalX" };

            NormalY1 = new TextBox();
            LabelNormalY = new Label { Text = "NormalY" };

            NormalZ1 = new TextBox();
            LabelNormalZ = new Label { Text = "NormalZ" };



            if (type == "Point")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, LabelX, LabelY, LabelZ };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Rectangle")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                Pointer(Height1, LabelHeight, 50, 90, 0, 90);
                Pointer(Width1, LabelWidth, 50, 120, 0, 120);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, Height1, Width1, LabelX, LabelY, LabelZ, LabelHeight, LabelWidth };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Circle")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                Pointer(Radius1, LabelRadius, 50, 90, 0, 90);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, Radius1, LabelX, LabelY, LabelZ, LabelRadius };
                objects.ForEach(x => panel.Controls.Add(x));

            }
            else if (type == "Sphere")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                Pointer(Radius1, LabelRadius, 50, 90, 0, 90);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, Radius1, LabelX, LabelY, LabelZ, LabelRadius };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "RectangularPrism")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                Pointer(Height1, LabelHeight, 50, 90, 0, 90);
                Pointer(Width1, LabelWidth, 50, 120, 0, 120);
                Pointer(Depth1, LabelDepth, 50, 150, 0, 150);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, Height1, Width1, Depth1, LabelX, LabelY, LabelZ, LabelHeight, LabelWidth, LabelDepth };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Cylinder")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                Pointer(Height1, LabelHeight, 50, 90, 0, 90);
                Pointer(Radius1, LabelRadius, 50, 120, 0, 120);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, Radius1, Height1, LabelX, LabelY, LabelZ, LabelRadius, LabelHeight };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Surface")
            {
                Pointer(X1, LabelX, 50, 0, 0, 0);
                Pointer(Y1, LabelY, 50, 30, 0, 30);
                Pointer(Z1, LabelZ, 50, 60, 0, 60);

                Pointer(NormalX1, LabelNormalX, 50, 90, 0, 90);
                Pointer(NormalY1, LabelNormalY, 50, 120, 0, 120);
                Pointer(NormalZ1, LabelNormalZ, 50, 150, 0, 150);

                List<Control> objects = new List<Control>() { X1, Y1, Z1, LabelX, LabelY, LabelZ, NormalZ1, LabelNormalZ, NormalY1, LabelNormalY, NormalX1, LabelNormalX };
                objects.ForEach(x => panel.Controls.Add(x));
            }
        }
        private void Configurations2(string type, Panel panel)
        {
            X2 = new TextBox();
            LabelX = new Label();
            LabelX.Text = "X";

            Y2 = new TextBox();
            LabelY = new Label();
            LabelY.Text = "Y";

            Z2 = new TextBox();
            LabelZ = new Label();
            LabelZ.Text = "Z";

            Height2 = new TextBox();
            LabelHeight = new Label { Text = "Height" };

            Width2 = new TextBox();
            LabelWidth = new Label { Text = "Weight" };

            Depth2 = new TextBox();
            LabelDepth = new Label { Text = "Depth" };

            Radius2 = new TextBox();
            LabelRadius = new Label { Text = "Radius" };

            NormalX2 = new TextBox();
            LabelNormalX = new Label { Text = "NormalX" };

            NormalY2 = new TextBox();
            LabelNormalY = new Label { Text = "NormalY" };

            NormalZ2 = new TextBox();
            LabelNormalZ = new Label { Text = "NormalZ" };



            if (type == "Point")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, LabelX, LabelY, LabelZ };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Rectangle")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                Pointer(Height2, LabelHeight, 50, 90, 0, 90);
                Pointer(Width2, LabelWidth, 50, 120, 0, 120);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, Height2, Width2, LabelX, LabelY, LabelZ, LabelHeight, LabelWidth };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Circle")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                Pointer(Radius2, LabelRadius, 50, 90, 0, 90);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, Radius2, LabelX, LabelY, LabelZ, LabelRadius };
                objects.ForEach(x => panel.Controls.Add(x));

            }
            else if (type == "Sphere")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                Pointer(Radius2, LabelRadius, 50, 90, 0, 90);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, Radius2, LabelX, LabelY, LabelZ, LabelRadius };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "RectangularPrism")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                Pointer(Height2, LabelHeight, 50, 90, 0, 90);
                Pointer(Width2, LabelWidth, 50, 120, 0, 120);
                Pointer(Depth2, LabelDepth, 50, 150, 0, 150);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, Height2, Width2, Depth2, LabelX, LabelY, LabelZ, LabelHeight, LabelWidth, LabelDepth };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Cylinder")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                Pointer(Height2, LabelHeight, 50, 90, 0, 90);
                Pointer(Radius2, LabelRadius, 50, 120, 0, 120);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, Radius2, Height2, LabelX, LabelY, LabelZ, LabelRadius, LabelHeight };
                objects.ForEach(x => panel.Controls.Add(x));
            }
            else if (type == "Surface")
            {
                Pointer(X2, LabelX, 50, 0, 0, 0);
                Pointer(Y2, LabelY, 50, 30, 0, 30);
                Pointer(Z2, LabelZ, 50, 60, 0, 60);

                Pointer(NormalX2, LabelNormalX, 50, 90, 0, 90);
                Pointer(NormalY2, LabelNormalY, 50, 120, 0, 120);
                Pointer(NormalZ2, LabelNormalZ, 50, 150, 0, 150);

                List<Control> objects = new List<Control>() { X2, Y2, Z2, NormalX2, NormalY2, NormalZ2, LabelX, LabelY, LabelZ, LabelNormalZ, LabelNormalY, LabelNormalX };
                objects.ForEach(x => panel.Controls.Add(x));
            }
        }

    }
}
