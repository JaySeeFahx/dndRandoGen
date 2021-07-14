using System.Collections.Generic;
using System;
using System.IO;


namespace dndRandoGen
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<string> races = new() { "Orc", "Human", "Elf", "Gnome", "Halfling" };
            List<string> classes = new() { "Warrior", "Bard", "Wizard", "Cleric", "Rogue" };
            List<string> genders = new() { "Male", "Female", "Non-Binary", "Trans-Masc", "Trans-Femme" };
        }
        private static string Randomize(List<string> list)
        {
            Random random = new();
            int index = random.Next(list.Count);
            string rand = list[index];
            return rand;
        }

        private static 

    }
}
