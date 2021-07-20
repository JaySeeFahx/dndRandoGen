using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndRandoGen
{
    class Generator
    {
        static RandomCharacter randChar = new();

        public List<string> races = new() { "Orc", "Human", "Elf", "Gnome", "Halfling" };
        public List<string> roles = new() { "Barbarian", "Bard", "Wizard", "Cleric", "Rogue" };
        public List<string> genders = new() { "Male", "Female", "Non-Binary", "Trans-Masc", "Trans-Femme" };

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
            randChar.Race = Randomize(races);
            randChar.Role = Randomize(roles);
            randChar.Gender = Randomize(genders);
            string[] array = { randChar.Race, randChar.Role, randChar.Gender };
            string joined = string.Join(" | ", array);
            Console.WriteLine($"        {joined}");
            Character.CharacterMenu();
        }
    }
}
