using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FigureCreatorApp.Menu;

namespace FigureCreatorApp.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(List<Point> points) : base(points)
        {
            this.Center = points[0];
            CalculateRadius();
            CalculateArea();
            CalculatePerimetr();

        }
        public void CalculateRadius()
        {
            this.Radius = CalculateSide(Points[0], Points[1]);
        }

        public void CalculatePerimetr()
        {
            this.Perimetr = Math.PI * Radius;
        }

        public void CalculateArea()
        {
            this.Area = Math.PI * Radius * Radius / 2;
        }

        public override void Rotate(double andle)
        {
            // TODO 
        }

        public override void Scale(double scale)
        {
            this.Radius *= scale;
            CalculateArea();
            CalculatePerimetr();
        }

        public static Circle Input()
        {
            List<Point> points = new List<Point>();
            InputManager inputManager = new InputManager();

            Console.WriteLine("Введите координаты центра круга");
            double x = inputManager.GetDoubleInput();
            double y = inputManager.GetDoubleInput();
            points.Add(new Point(x, y));

            Console.WriteLine("Введите координаты точки которая будет находиться на круге");
            x = inputManager.GetDoubleInput();
            y = inputManager.GetDoubleInput();
            points.Add(new Point(x, y));

            return new Circle(points);
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            String name = GetType().Name;

            result
                    .Append(name)
                    .Append("\nКоординаты центра круга")
                    .Append(0)
                    .Append(": x=")
                    .Append(Points[0].X)
                    .Append(", y=")
                    .Append(Points[0].Y)
                    .Append(";")
                    .Append("\nКоординаты точки на окружности")
                    .Append(1)
                    .Append(": x=")
                    .Append(Points[1].X)
                    .Append(", y=")
                    .Append(Points[1].Y)
                    .Append(";")
                    .Append("\nРадиус: ")
                    .Append(Radius)
                    .Append("\nПлощадь: ")
                    .Append(Area)
                    .Append("\nПериметр: ")
                    .Append(Perimetr);

            return result.ToString();
        }
    }
}
