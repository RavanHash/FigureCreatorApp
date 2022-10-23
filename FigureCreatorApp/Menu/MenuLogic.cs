using System;

namespace FigureCreatorApp.Menu
{
    internal partial class Program
    {
        public class MenuLogic
        {
            public void MainMenu()
            {
                MenuUI menuUi = new MenuUI();

                InputManager inputManager = new InputManager();
                int option = inputManager.ChooseOption(0, 4);

                switch (option)
                {
                    case 1:

                        break;
                    case 2:
                        menuUi.ShowCreateFigureMenu();
                        ChooseFigure();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }

            public void ChooseFigure()
            {
                MenuUI menuUi = new MenuUI();

                InputManager inputManager = new InputManager();
                int option = inputManager.ChooseOption(0, 5);

                switch (option)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 0:
                        menuUi.ShowMainMenu();
                        MainMenu();
                        break;
                }
            }
        }
    }
}
