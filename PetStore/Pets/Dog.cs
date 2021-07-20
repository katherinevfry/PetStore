using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog //implicitly internal
    {
        //class contain behavior, code, etc. this is almost, but not quite, analagous to objects in JS
        //method = behavior roughly = to functions
        //properties = statefulness
        //fields = internal to class
        //if you set something to private it sets the scope to ONLY this class (e.g., dog) THIS IS DEFAULT if you don't explicitly declare
        // public is everything, can be accessed by anything
        //internal ... anything in this project can access it
        //protected anything that inherits from me can access

        //accessibility or access modifier...who has access to this property? most properties are public
        //AP     type  name(capitalize) get and set must be added in curly braces
        public string Size { get; set; } //auto-property
        public short Weight { get; set; }
        public string Name { get; set; }

        //Method Signature
        //there are four parts to a method signature
        //return type: void - means you're not returning anything
        //any parameters have to be defined (e.g. string noise)
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily");
        }
        //params are camel case
        public void Eat(string typeOfFood)
        {
            if (typeOfFood == "healthy food")
            //if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
            {
                Weight -= 2;
            }
            else
            {
                Weight += 2;
            }
            Console.WriteLine($"{Name} ate {typeOfFood} and now weighs {Weight} pounds");
        }
    }
}
