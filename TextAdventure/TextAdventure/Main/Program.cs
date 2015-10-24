using System;
using System.Reflection;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string _title = "Dungeon Crawler";
            string _version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string _creators = "Errorcodebin and RaveCode";
            Console.Title = _title + " | Version " + _version + " | by " + _creators;

            Main prog = new Main();
            prog.Start();
        }
    }
}
