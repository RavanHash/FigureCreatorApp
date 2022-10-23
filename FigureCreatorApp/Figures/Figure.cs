using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FigureCreatorApp.Figures
{
    public abstract class Figure
    {
        public List<Point> Points { get; protected set; }
        public  Point Center { get; protected set; }
        public double Area { get; protected set; }
        public double Perimetr { get; protected set; }

        public Figure(List<Point> points)
        {
            this.Points = points;
        }

        public abstract void Move(Point point);
        public abstract void Scale(double scale);
        public abstract void Rotate(double andle);

        public double CalculateSide(Point firstCoordinate, Point secondCoordinate)
        {
            return (Math.Pow(Math.Pow(secondCoordinate.X - firstCoordinate.X, 2) + Math.Pow(secondCoordinate.Y - firstCoordinate.Y, 2), 0.5));
        }

        public void CalculateCenter()
        {
            double sumX = 0, sumY = 0;

            foreach (Point point in Points)
            {
                sumX += point.X;
                sumY += point.Y;
            }
            Center = new Point(sumX / Points.Count, sumY / Points.Count);
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            String name = GetType().Name;

            result.Append(name);
            for (int i = 0; i < Points.Count; i++)
            {
                result
                        .Append("\nКоординаты вершины N ")
                        .Append(i + 1)
                        .Append(": x=")
                        .Append(Convert.ToString(Points[i].X))
                        .Append(", y=")
                        .Append(Convert.ToString(Points[i].Y))
                        .Append(";");
            }
            result.Append("\nПлощадь: ").Append(Area).Append("\nПериметр: ").Append(Perimetr).Append("\n");

            return result.ToString();
        }

        //public override bool Equals(Object o)
        //{
        //    if (this == o) return true;
        //    if (o == null || getClass() != o.getClass()) return false;
        //    Figure figure = (Figure)o;
        //    return Objects.equals(Points, figure.Points);
        //}
    }
}
