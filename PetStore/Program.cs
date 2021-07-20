using PetStore.Pets; //import the dawg
using System;


namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var melbaDog = new Dog();
            melbaDog.Name = "Melba";
            melbaDog.Size = "medium";
            melbaDog.Weight = 60;
            melbaDog.Eat("chocolate");

            var barley = new Dog();
            barley.Name = "Barley";
            barley.Size = "Medium";
            barley.Weight = 50;
            barley.Eat("healthy food");
        }
    }
}
