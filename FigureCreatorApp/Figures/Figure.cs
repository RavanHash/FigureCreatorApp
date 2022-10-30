using System;
using System.Text;
using System.Collections.Generic;

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

        public abstract void Scale(double scale);
        public abstract void Rotate(double andle);

        public virtual void Move(Point step)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                double x = this.Points[i].X + step.X;
                double y = this.Points[i].Y + step.Y;
                Points[i] = new Point(x, y);
            }
            CalculateCenter();
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

        public double CalculateSide(Point firstCoordinate, Point secondCoordinate)
        {
            return (Math.Pow(Math.Pow(secondCoordinate.X - firstCoordinate.X, 2) + Math.Pow(secondCoordinate.Y - firstCoordinate.Y, 2), 0.5));
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

        public override bool Equals(Object obj)
        {
            if (this == obj) 
                return true;

            if (obj == null || GetType() != obj.GetType()) 
                return false;

            Figure figure = (Figure)obj;
            return Points.Equals(figure.Points);
        }
    }
}
