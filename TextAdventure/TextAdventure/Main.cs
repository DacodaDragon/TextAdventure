using System;
using System.Reflection;

namespace TextAdventure
{
    class Main
    {
        string TITLE = "Dungeon Crawler";
        string VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        string CREATORS = "Jake and Codi";

        bool IS_RUNNING = true;
        Renderer renderer;

        public void start()
        {
            Console.Title = TITLE + " | Version " + VERSION + " | " + CREATORS;
            
            renderer = new Renderer();
            renderer.ScreenInit(64,64);
        }

        public void loop()
        {
            while (IS_RUNNING)
            {
                string[] temp = { " /\\ /\\ ",
                                  "(O _ O)" };

                renderer.Clear();

                    renderer.DrawString(1, 1, "HELLO WORLD", Renderer.textAlingment.middle);
                    renderer.DrawSquare(0,0,64, 16, '~', ConsoleColor.Blue);
                    renderer.DrawSprite(4, 4, temp, ConsoleColor.DarkMagenta);
                    renderer.DrawSprite(1, 16, temp, ConsoleColor.Red);
                    renderer.DrawSprite(7, 43, temp, ConsoleColor.Green);
                    renderer.DrawSprite(30, 16, temp, ConsoleColor.DarkCyan);
                    renderer.DrawSprite(2, 50, temp, ConsoleColor.Cyan);
                    renderer.DrawSprite(20, 40, temp, ConsoleColor.Red);
                    renderer.DrawSprite(50, 10, temp, ConsoleColor.Green);

                renderer.Render();

                ConsoleKey tmp = Console.ReadKey().Key;
                if (tmp == ConsoleKey.Escape) IS_RUNNING = false;
            }
        }
    }
}