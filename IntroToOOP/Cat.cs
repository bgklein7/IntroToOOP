﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //I need STATES

        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

            public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        //I need BEHAVIORS

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

        public void Eat()
        {
            if (isHungry)
            {

                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}
