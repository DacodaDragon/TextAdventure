﻿using System;

namespace TextAdventure
{
    class Sprite
    {
        public readonly Char[,] _sprite;

        public readonly int _posX;
        public readonly int _posY;

        public readonly int _spriteWidth;
        public readonly int _spriteHeight;

        public Sprite(int posX, int posY, string[] Sprite, ConsoleColor Color = ConsoleColor.White)
        { // Needs testing

            _posX = posX;
            _posY = posY;

            _spriteHeight = Sprite.Length;
            _spriteWidth = Sprite[0].Length;

            _sprite = new Char[_spriteHeight,_spriteWidth];

            for (int y = 0; y < _spriteHeight; y++)
            {
                for (int x = 0; x < _spriteWidth; x++)
                {
                    _sprite[x, y] = new Char(Sprite[y][x],Color);
                }
            }
        }

        public Sprite(int posX, int posY, Char[,] Sprite)
        { // work in progress
            _posX = posX;
            _posY = posY;
            _sprite = Sprite;
        }
    }
}