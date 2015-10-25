using System;

namespace TextAdventure
{
    class Char
    {
        public readonly char letter; 
        public readonly ConsoleColor colorFront;
        public readonly ConsoleColor colorBack;
        
        public Char(char character, ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            letter = character;
            colorFront = foreground;
            colorBack = background;
        } 
    }
}
