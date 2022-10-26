using System;
using System.Collections.Generic;
using FigureCreatorApp.Menu;

namespace FigureCreatorApp.Figures
{
    public class Square : Polygon
    {
        public Square(List<Point> points) : base(points) { }

        public static Square Input()
        {
            List<Point> points = new List<Point>();
            InputManager inputManager = new InputManager();

            Console.WriteLine("Введите координаты фигуры");
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + " точка ");
                double x = inputManager.GetDoubleInput();
                double y = inputManager.GetDoubleInput();

                points[i] = new Point(x, y);
            }
            Console.WriteLine(" Фигура построена! ");
            return new Square(points);
        }
    }
}
