using System;
using System.IO;
using FigureCreatorApp.Figures;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FigureCreatorApp.Mangers
{
    public static class FileManager
    {
        public static List<Figure> FigureList = new List<Figure>();

        private static string path = @"../../figure.json";

        public static void SaveToFile()
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                Newtonsoft.Json.JsonSerializer jsonSerializer = Newtonsoft.Json.JsonSerializer.
                    Create(new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects, Formatting = Formatting.Indented });
                jsonSerializer.Serialize(sw, FigureList);
            }
        }
         
        public static List<Figure> GetListOfFiguresFromFile()
        {
            using(StreamReader sr = new StreamReader(path))
            {
                Newtonsoft.Json.JsonSerializer jsonSerializer = Newtonsoft.Json.JsonSerializer.
                    Create(new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects, Formatting = Formatting.Indented });

                List<Figure> result = new List<Figure>();
                result = (List<Figure>)jsonSerializer.Deserialize(sr, result.GetType());

                return result;
            }
        }

        public static void ShowAllUnsavedFigures()
        {
            for (int i = 0; i < FigureList.Count; i++)
            {
                Console.WriteLine("------" + (i + 1) + "------");
                Console.WriteLine(FigureList[i].ToString());
            }
        }
        
        public static void ShowAllSavedFigures()
        {
            FigureList = GetListOfFiguresFromFile();
            for (int i = 0; i < FigureList.Count; i++)
            {
                Console.WriteLine("------" + (i + 1) + "------");
                Console.WriteLine(FigureList[i].ToString());
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

        public static void InitializeFromFile()
        {
            FigureList = GetListOfFiguresFromFile();
        }
    }
}
