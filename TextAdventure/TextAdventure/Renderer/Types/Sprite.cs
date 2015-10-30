using System;

namespace TextAdventure
{
    #region Structures

    public struct SpriteSize
    {
        public readonly int width, height;
        public SpriteSize(int _width, int _height)
        {
            width = _width;
            height = _height;
        }
    }

    public struct SpritePosition
    {
        public readonly int x, y;
        public SpritePosition(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

    public struct SpriteRect
    {
        SpritePosition position;
        SpriteSize size;

        public SpriteRect(SpritePosition _position, SpriteSize _size)
        {
            position = _position;
            size = _size;
        }
    }

#endregion

    class Sprite
    {
        public readonly Char[,] sprite;
        public readonly SpriteRect rect;
        public readonly string name;

        public Sprite(string[] Sprite, SpritePosition _position, ConsoleColor Color = ConsoleColor.White)
        {
            SpriteSize size = new SpriteSize(Sprite[0].Length, Sprite.Length);
            rect = new SpriteRect(_position, size);

            sprite = new Char[size.height,size.width];

            for (int x = 0; x < size.width; x++)
            {
                for (int y = 0; y < size.height; y++)
                {
                    sprite[x, y] = new Char(Sprite[y][x], Color);
                }
            }
        }

        public Sprite(Char[,] Sprite, SpritePosition _position)
        { // work in progress
            //_posX = posX;
            //_posY = posY;
            sprite = Sprite;
        }
    }
}