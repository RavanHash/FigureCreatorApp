using System;

namespace FigureCreatorApp.Menu
{
    internal partial class Program
    {
        public class InputManager
        {
            public int ChooseOption(int min, int max)
            {
                Console.Write(" Enter integer number: ");

                int number;
                bool isInt = int.TryParse(Console.ReadLine(), out number);

                while (!isInt || number < min || number > max)
                {
                    Console.Write(" This is not valid input. Please try again: ");
                    isInt = int.TryParse(Console.ReadLine(), out number);
                }

                return number;
            }
        }
    }

}
