using System;
using System.Threading;

namespace TextAdventure
{
    class Renderer
    {
        private ColoredChar[,] canvas;
        private int canvasWidth;
        private int canvasHeight;
        enum textAlingment
        {
            left,middle,right
        }

        const ConsoleColor colorMain = ConsoleColor.White;

        public void ScreenInit(int SizeX, int SizeY)
        {
            canvas = new ColoredChar[SizeX,SizeY];
            canvasWidth = SizeX;
            canvasHeight = SizeY;
        }

        public void DrawSquare(int posX, int posY, int sizeX, int sizeY, char character, ConsoleColor color = colorMain)
        {
            for (int y = 0; y < sizeY; y++)
            {

                for (int x = 0; x < sizeX; x++)
                {
                    if (posY + y > canvasHeight) { continue; }
                    else if (posX + x > canvasWidth) { continue; }

                    canvas[posX + x, posY + y] = new ColoredChar('~', color);
                }
            }
        }

        public void DrawSprite(int _x, int _y, string[] sprite,ConsoleColor color = colorMain)
        {
            for (int y = 0; y < sprite.Length; y++)
            {
                for (int x = 0; x < sprite[0].Length; x++)
                {
                    canvas[x+_x, y+_y] = new ColoredChar(sprite[y][x], color);
                }
            }
        }

        void DrawString(int x, int y,string text, textAlingment TextAlignment,ConsoleColor color)
        {
            switch (TextAlignment)
            {
                case textAlingment.left:
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            canvas[x + i, y] = new ColoredChar(text[i],color);
                        }
                    }
                    break;
                case textAlingment.middle:
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            canvas[(x + i) - (int)Math.Round(text.Length / 2d), y] = new ColoredChar(text[i], color);
                        }
                    }
                    break;
                case textAlingment.right:
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            canvas[(x + i) - text.Length, y] = new ColoredChar(text[i], color);
                        }
                    }
                    break;
            }

        }

        public void Render()
        {
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    if (i * 2 > Console.BufferWidth - 1) continue;
                    else if (canvas[i, j] == null) continue;

                    Console.SetCursorPosition(i*2, j);
                    Console.ForegroundColor = canvas[i, j].colorFront;
                    Console.BackgroundColor = canvas[i, j].colorBack;
                    Console.Write(canvas[i,j].letter);
                }
            }
        }
        
        public void Clear()
        {
            Console.Clear();
        }
    }
}