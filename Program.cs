using System.Collections.Generic;
using System;
using System.IO;


namespace dndRandoGen
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome Adventurer!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1) Create New Character");
            Console.WriteLine("2) View Saved Character");
            Console.WriteLine("3) Exit");
            Console.Write("Select and option:");

            switch (Console.ReadLine())
            {
                case "1":
                    NewChar();
                    return true;
                case "2":
                    SavedChar();
                    return true;
                case "3":
                    return false;
                default:
                    return false;
            }
        }
    }
}
