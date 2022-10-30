using System;
using FigureCreatorApp.Menu;
using FigureCreatorApp.Mangers;
using FigureCreatorApp.Figures;

namespace FigureCreatorApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            FileManager.InitializeAtStart();
            MenuLogic.MainMenu();

            Console.ReadKey();
        }
    }
}
