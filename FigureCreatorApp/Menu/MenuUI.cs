using System;

namespace FigureCreatorApp.Menu
{
    internal partial class Program
    {
        public class MenuUI
        {
            public void ShowMainMenu()
            {
                Console.WriteLine();
                Console.WriteLine(" Choose one option:");
                Console.WriteLine();
                Console.WriteLine(" 1. Show all figures");
                Console.WriteLine(" 2. Create a figure");
                Console.WriteLine(" 3. Change figure");
                Console.WriteLine(" 4. Save to file");
                Console.WriteLine();
                Console.WriteLine(" 0. Exit");
                Console.WriteLine();
            }

            public void ShowCreateFigureMenu()
            {
                Console.WriteLine();
                Console.WriteLine(" Choose one option:");
                Console.WriteLine();
                Console.WriteLine(" 1. Square");
                Console.WriteLine(" 2. Rectangle");
                Console.WriteLine(" 3. Triangle");
                Console.WriteLine(" 4. Circle");
                Console.WriteLine(" 5. N-angle");
                Console.WriteLine();
                Console.WriteLine(" 0. Back to Main Menu");
                Console.WriteLine();
            }
        }
    }

}
