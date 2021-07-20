using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndRandoGen
{
    //Sets up fields needed for a random character
    public class RandomCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
    }
}
