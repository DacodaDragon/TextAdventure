using System;

namespace TextAdventure
{
    class ColoredChar
    {
        public readonly char letter;
        public readonly ConsoleColor colorFront;
        public readonly ConsoleColor colorBack;
        
        public ColoredChar(char character, ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            letter = character;
            colorFront = foreground;
            colorBack = background;
        } 
    }
}
