using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Tiger
    {
        public string Size { get; set; }
        public int NumberOfKills { get; set; }
        public short Speed { get; set; }
        public string Name { get; set; }

        //field
        //fields are generally private
        //fields get prefixed with an underscore and are camel case
        private int _numberOfBites;
        //I can also say:
        //int _numberOfBites;

        public void Bite(string handlerName)
        {
            _numberOfBites++;
            Console.WriteLine($"{Name} the tiger just bit {handlerName} That's the {_numberOfBites} time!");
        }

        //fields are things I wanna keep private and not expose to the pblic
    }
}
