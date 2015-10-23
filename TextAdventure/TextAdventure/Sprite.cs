using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Sprite
    {
        public readonly ColoredChar[,] sprite;

        public readonly int posX;
        public readonly int posY;

        public readonly int spriteWidth;
        public readonly int spriteHeight;

        public Sprite(int X, int Y, string[] Sprite, ConsoleColor Color = ConsoleColor.Black)
        { // Needs testing

            posX = X;
            posY = Y;

            spriteHeight = Sprite.Length;
            spriteWidth = Sprite[0].Length;

            sprite = new ColoredChar[spriteHeight,spriteWidth];

            for (int y = 0; y < spriteHeight; y++)
            {
                for (int x = 0; x < spriteWidth; x++)
                {
                    sprite[x, y] = new ColoredChar(Sprite[y][x],Color);
                }
            }
        }

        public Sprite(int X, int Y, ColoredChar[,] Sprite)
        { // work in progress
            posX = X;
            posY = Y;
            sprite = Sprite;
        }
    }
}