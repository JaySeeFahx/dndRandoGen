using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace dndRandoGen
{
    //Creates new character
    class Character
    {
        static SavedCharacters savedChar = new();
        static Generator randChar = new();

        //Show menu with options available for character info
        public static bool CharacterMenu()
        {
            Console.WriteLine("\nThe fates have brought forth your character!");
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Reroll this character");
            Console.WriteLine("2) Go to save menu");
            Console.WriteLine("3) Return to the previous menu");
            Console.Write("Choose wisely... : ");

            int switchCall = int.Parse(Console.ReadLine());

            switch (switchCall)
            {
                case 1:
                    Console.Clear();
                    randChar.NewChar(); //random character generator
                    return true;
                case 2:
                    savedChar.SaveMenu(); //Json file
                    return true;
                case 3:
                    Console.Clear();
                    return false;
                default:
                    Console.Clear();
                    Console.WriteLine("Please choose carefully! The option you chose isn't valid. Press any key to return to the main menu!\n");
                    Console.ReadKey();
                    return true;
            }
        }
    }
}
