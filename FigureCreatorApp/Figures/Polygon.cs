using System;
using System.Collections.Generic;

namespace FigureCreatorApp.Figures
{
    public class Polygon : Figure
    {
        public Polygon(List<Point> points) : base(points)
        {
            this.CalculateCenter();
            this.CalculateArea();
            this.CalculatePerimetr();
        }

        public void CalculateArea()
        {
            Area = 0;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                Area += Math.Abs(Points[i].X * Points[i + 1].Y - Points[i].X * Points[i + 1].X);
            }
        }

        public void CalculatePerimetr()
        {
            Perimetr = 0;

            for (int i = 0; i < Points.Count - 1; i++)
            {
                Perimetr += Math.Sqrt(Pow(Points[i + 1].X - Points[i].X) + Pow(Points[i + 1].Y - Points[i].Y));
            }
            Perimetr += Math.Sqrt(Pow(Points[Points.Count - 1].X - Points[0].X) + Pow(Points[Points.Count - 1].Y - Points[0].Y));
        }

        public override void Move(Point point)
        {

        }

        public override void Scale(double scale)
        {
            
        }

        public override void Rotate(double angle)
        {
            
        }

        public double Pow(double a)
        {
            return a * a;
        }
    }
}
