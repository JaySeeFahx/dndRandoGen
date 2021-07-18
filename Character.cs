using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace dndRandoGen
{
    //Sets up fields needed for a random character
    class RandomCharacter
    {
        public string Race { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
    }
    //Creates new character
    class Character
    {
        
        List<string> races = new() { "Orc", "Human", "Elf", "Gnome", "Halfling" };
        List<string> roles = new() { "Fighter", "Bard", "Wizard", "Cleric", "Rogue" };
        List<string> genders = new() { "Male", "Female", "Non-Binary", "Trans-Masc", "Trans-Femme" };

        // Randomizes the races, roles, and genders lists.
        private static string Randomize(List<string> list)
        {
            Random random = new();
            int index = random.Next(list.Count);
            string rand = list[index];
            return rand;
        }
        //Show options available for character info
        private static bool CharacterMenu()
        {
            Character newChar = new();
            RandomCharacter randChar = new();
            Console.WriteLine("\nThe fates have brought forth your character!");
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Reroll this character. 😥");
            Console.WriteLine("2) Save this character. 😁");
            Console.WriteLine("3) Return to the previous menu.");
            Console.WriteLine("Choose wisely...");
            try 
            {
                switch (newChar.SwitchCall())
                {
                    case 1:
                        Console.Clear();
                        newChar.NewChar();
                        return true;
                    case 2:
                        Console.Clear();
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
            catch
            {
                throw;
            }
        }

        //Creats an array, holds the new character information in a string
        public void NewChar()
        {
            RandomCharacter randChar = new();
            randChar.Race = Randomize(races);
            randChar.Role = Randomize(roles);
            randChar.Gender = Randomize(genders);
            string[] array = { randChar.Race, randChar.Role, randChar.Gender };
            string joined = string.Join(" | ", array);
            Console.WriteLine(joined);
        }

        public void SaveChar()
        { 
            
        }
        public int SwitchCall()
        {
            string input = Console.ReadLine();
            int switchCall = int.Parse(input);
            return switchCall;
        }
    }
}
