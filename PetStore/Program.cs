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

            //object initializer
            var tiger = new Tiger
            {
                Name = "Kisa",
                NumberOfKills = 0,
                Size = "Medium"
            };

            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");

            var bear = new Bear("Yogi", "Brown");
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(5);

            bear.BestTigerFriend = tiger;
            //passing an object
            //bear.BestTigerFriend = new Tiger { Name = "Katy", NumberOfKills = 0, Size = "baby" };

            bear.HangOutWithBestFriend();
        }
    }
}
