using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //STATES
        //fields
        private string hairLength;
        private int height;
        private string runningSpeed;
        private int weight;

        //Properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        //BEHAVIORS

        //Constructors
        public Dog()
        {
            //this is default constructor
            //takes no parameters, ie nothing in parentheses
        }

        public Dog(string hairLength, int height, string runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        //methods
        public void Run()
        {
            if (runningSpeed  == "slow") //if use just variable name in bool assumption is that it is true
            {

                Console.WriteLine("Dog does not win race");
            }
            if (runningSpeed == "fast")
            {
                Console.WriteLine("Dog gets squirrel");
            }
           
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            Console.WriteLine("\a");
        }

        public void Cuddle()
        {
            if(weight > 100)
            {
                Console.WriteLine("Ouch! Get off my lap");
            }
            else
            {
                Console.WriteLine("Hop on up");
            }
        }

    }
}
