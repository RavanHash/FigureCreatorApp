using System;

namespace FigureCreatorApp.Menu
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

        public double GetDoubleInput()
        {
            double number;

            Console.Write("Enter double number: ");

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }

            return number;
        }
    }
}
