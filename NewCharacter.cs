using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndRandoGen
{
    //Creates new character
    class NewCharacter
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

        //Creats an array to hold the new character information
        public void NewChar()
        {
            RandomCharacter newChar = new RandomCharacter();
            newChar.Race = Randomize(races);
            newChar.Role = Randomize(roles);
            newChar.Gender = Randomize(genders);
            string[] array = { newChar.Race, newChar.Role, newChar.Gender };
            string joined = string.Join(" | ", array);
            Console.WriteLine(joined);
        }
    }
}
