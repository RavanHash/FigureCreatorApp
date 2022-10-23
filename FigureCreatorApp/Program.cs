using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FigureCreatorApp.Menu.Program;
using FigureCreatorApp.Figures;

namespace FigureCreatorApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //MenuUI menuUi = new MenuUI();
            //MenuLogic menuLogic = new MenuLogic();


            //menuUi.ShowMainMenu();
            //menuLogic.MainMenu();

            List<Point> points = new List<Point>();

            Point a = new Point(0, 0);
            points.Add(a);
            Point b = new Point(0, 2);
            points.Add(b);
            Point c = new Point(2, 2);
            points.Add(c);
            Point d = new Point(2, 0);
            points.Add(d);

            Figure figure = new Polygon(points);

            Console.WriteLine(figure.ToString());

            Console.ReadKey();
        }
    }
}
