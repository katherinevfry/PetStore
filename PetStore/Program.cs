using PetStore.Pets; //import the dawg
using System;


namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var melbaDog = new Dog("Melba", 60, "Medium");
            melbaDog.Eat("chocolate");

            var barley = new Dog("Barley", 50, "Medium");
            //barley.Name = "Barley";
            //barley.Size = "Medium";
            //barley.Weight = 50;
            barley.Eat("healthy food");
        }
    }
}
