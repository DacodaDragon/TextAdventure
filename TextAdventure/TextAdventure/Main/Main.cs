using System;

namespace TextAdventure
{
    class Main
    {
        bool isRunning = true;

        public void Start()
        {
            while (isRunning)
            {
                ObsoleteRenderer renderer = new ObsoleteRenderer();
                renderer.ScreenInit(64, 64);

                string[] temp = { " /\\ /\\ ",
                                  "(O _ O)" };

                renderer.Clear();

                renderer.DrawSquare(0, 0, 64, 16, '~', ConsoleColor.Blue);
                renderer.DrawSprite(4, 4, temp, ConsoleColor.DarkMagenta);
                renderer.DrawSprite(1, 16, temp, ConsoleColor.Red);
                renderer.DrawSprite(7, 43, temp, ConsoleColor.Green);
                renderer.DrawSprite(30, 16, temp, ConsoleColor.DarkCyan);
                renderer.DrawSprite(2, 50, temp, ConsoleColor.Cyan);
                renderer.DrawSprite(20, 40, temp, ConsoleColor.Red);
                renderer.DrawSprite(50, 10, temp, ConsoleColor.Green);
                renderer.DrawString(10, 1, "HELLO WORLD", ObsoleteRenderer.textAlingment.middle);

                renderer.Render();

                Input();
            }
        }

        private void Input()
        {
            ConsoleKey keyPress = Console.ReadKey(true).Key;

            switch (keyPress)
            {
                case ConsoleKey.Escape:
                    isRunning = false;
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    // go up
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    // go down
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    // go left
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    // go right
                    break;
            }
        }
    }
}