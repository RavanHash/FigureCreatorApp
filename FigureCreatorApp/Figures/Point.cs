using System;

namespace FigureCreatorApp.Figures
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override String ToString()
        {
            String result = "( " + X + "; " + Y + " ) ";
            return result;
        }

        //public override bool Equals(Object obj)
        //{
        //    if (this == obj) 
        //        return true;

        //    if (obj == null || getClass() != obj.getClass()) 
        //        return false;

        //    Point point = (Point)obj;
        //    return Double.compare(point.X, X) == 0 && Double.compare(point.Y, Y) == 0;
        //}
    }
}
