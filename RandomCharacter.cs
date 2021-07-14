using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndRandoGen
{
    class RandomCharacter
    {
        List<string> races = new() { "Orc", "Human", "Elf", "Gnome", "Halfling" };
        List<string> classes = new() { "Fighter", "Bard", "Wizard", "Cleric", "Rogue" };
        List<string> genders = new() { "Male", "Female", "Non-Binary", "Trans-Masc", "Trans-Femme" };

        private static string Randomize(List<string> list)
        {
            Random random = new();
            int index = random.Next(list.Count);
            string rand = list[index];
            return rand;
        }
    }
}
