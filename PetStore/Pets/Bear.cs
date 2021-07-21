using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Bear
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int NumberOfFishEaten { get; private set; } //only I can change the property
        public string EducationLevel { get; set; } = "GED"; //setting default value
        public Tiger BestTigerFriend { get; set; }
        //public bool LovesHoney { get; } //removing set makes the property readonly. it can only be set within the constructor
        
        //espression bodied readonly property
        public bool LovesHoney => Name == "Winnie the Pooh"; // since only winnie loves honey we can declare it like this. still only a getter
        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED"; //also setting default value

            //if (name == "winnie the pooh")
            //{
            //    LovesHoney = true;
            //}
            if (name == "yogi")
            {
                EducationLevel = "Above Average";
            }
        }

        //constructor overloading ... this extends the previous public bear. basically constructing different use cases
        //expression bodied method
        public Bear(string name, string type, string educationLevel) : this(name, type) => EducationLevel = educationLevel; //use a fat arrow if u want
        //{
        //    EducationLevel = educationLevel;
        //}



        public void EatFish(int howMany)
        {
            if (howMany <= 0) return; //bail out

            NumberOfFishEaten += howMany;
        }

        public void HangOutWithBestFriend()
        {
            Console.WriteLine($"{Name} the bear is hanging out with its best tiger friend {BestTigerFriend.Name}" +
                $" the {BestTigerFriend.Size} tiger");
        }

    }
}
