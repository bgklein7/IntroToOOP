using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
      //STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        //BEHAVIORS

        //Constructors
        public Cat() 
        {
            //this is default constructor
            //takes no parameters, ie nothing in parentheses
        }

        public Cat (string name, int age, string furColor)
        {
            this.name = name;  
            this.age = age;
            this.furColor = furColor;
           
        }

        //methods
        public void Eat()
        {
            if (isHungry) //if use just variable name in bool assumption is that it is true
            {

                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (name + " has a hairball");
            }
            else
            {
                return (name + " is nicely groomed");
            }

        }
    }
}
