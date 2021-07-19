using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace dndRandoGen
{
    //Sets up fields needed for a random character
    public class RandomCharacter
    {
        public string Race { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }

        // Randomizes the race, role, and gender lists.
        private static string Randomize(List<string> list)
        {
            Random random = new();
            int index = random.Next(list.Count);
            string rand = list[index];
            return rand;
        }

        //Creats an array, holds the new character information in a string
        public void NewChar()
        {
            Character newChar = new();
            RandomCharacter randChar = new();
            randChar.Race = Randomize(newChar.races);
            randChar.Role = Randomize(newChar.roles);
            randChar.Gender = Randomize(newChar.genders);
            string[] array = { randChar.Race, randChar.Role, randChar.Gender };
            string joined = string.Join(" | ", array);
            Console.WriteLine($"        {joined}");
            Character.CharacterMenu();
        }
    }

    //Creates new character
    class Character
    {
        
        public List<string> races = new() { "Orc", "Human", "Elf", "Gnome", "Halfling" };
        public List<string> roles = new() { "Fighter", "Bard", "Wizard", "Cleric", "Rogue" };
        public List<string> genders = new() { "Male", "Female", "Non-Binary", "Trans-Masc", "Trans-Femme" };

        
        //Show menu with options available for character info
        public static bool CharacterMenu()
        {
            RandomCharacter randChar = new();
            SavedCharacters savedChar = new();
            Console.WriteLine("\nThe fates have brought forth your character!");
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Reroll this character.");
            Console.WriteLine("2) Save this character.");
            Console.WriteLine("3) Return to the previous menu.");
            Console.Write("Choose wisely... :");

            string input = Console.ReadLine();
            int switchCall = int.Parse(input);

            switch (switchCall)
            {
                case 1:
                    Console.Clear();
                    randChar.NewChar(); //random character generator
                    return true;
                case 2:
                    Console.Clear();
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
