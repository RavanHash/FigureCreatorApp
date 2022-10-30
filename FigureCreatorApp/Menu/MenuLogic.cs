using System;
using FigureCreatorApp.Figures;
using FigureCreatorApp.Mangers;
using FigureCreatorApp.Factories;

namespace FigureCreatorApp.Menu
{
    public static class MenuLogic
    {
        public static void MainMenu()
        {
            MenuUI.ShowMainMenu();
            int option = InputManager.ChooseOption(0, 4);
            switch (option)
            {
                case 1:
                    FileManager.ShowAllFigures();
                    MainMenu();
                    break;
                case 2:
                    ChooseFigure();
                    break;
                case 3:

                    break;
                case 4:
                    FileManager.SaveToFile();
                    MainMenu();
                    break;
                case 0:
                    FileManager.SaveToFile();
                    Environment.Exit(0);
                    break;
            }
        }

        public static void ChooseFigure()
        {
            MenuUI.ShowCreateFigureMenu();

            FigureCreator figureCreator = FigureCreator.SelectFigure();
            Figure figure = figureCreator.CreateFigure();
            FileManager.FigureList.Add(figure);
            MainMenu();
        }
    }
}
