using System;
using System.IO;
using FigureCreatorApp.Figures;
using System.Collections.Generic;

namespace FigureCreatorApp.Mangers
{
    public static class FileManager
    {
        public static List<Figure> FigureList = new List<Figure>();

        private static string path = @"../../figure.txt";

        public static void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach(var figure in FigureList)
                {
                    sw.WriteLine(figure.ToString());
                }
            }
        }
        
        public static void ReadFromFile()
        {

        }

        public static void ShowAllFigures()
        {
            foreach (var figure in FigureList)
            {
                Console.WriteLine(figure.ToString());
            }
        }

        public static void InitializeAtStart()
        {
            List<Point> trianglePoints = new List<Point>();
            trianglePoints.AddRange(new List<Point> 
            { 
                new Point(3, 2), 
                new Point(3, 8), 
                new Point(10, 8) 
            });
            Triangle triangle = new Triangle(trianglePoints);

            List<Point> squarePoints = new List<Point>();
            squarePoints.AddRange(new List<Point>
            {
                new Point(3, 2),
                new Point(3, 8),
                new Point(10, 8),
                new Point(10, 2)
            });
            Square square = new Square(squarePoints);

            List<Point> circlePoints = new List<Point>();
            circlePoints.AddRange(new List<Point>
            {
                new Point(2, 2),
                new Point(2, 4)
            });
            Circle circle = new Circle(circlePoints);

            FigureList.AddRange(new List<Figure>
            {
                triangle,
                square,
                circle
            });
        }
    }
}
