using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();

            secondCat.Meow();

            firstCat.HairLength = "too long";
            Console.WriteLine(firstCat.Hairball());

            Dog firstDog = new Dog("long", 18, "fast", 40 );

            Dog secondDog = new Dog("short", 24, "slow", 101);

            firstDog.Run();

            secondDog.Cuddle();

            firstDog.Bark();
        }
    }
}
