using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class SuperHero
    {
        private bool xRayVision;
        private bool spandex;
        private string weaponChoice;
        private string superPower;

        public string WeaponChoice
        {
            get { return this.superPower; }
            set { this.superPower = value; }
        }

        public SuperHero()
        {
        }

        public SuperHero(bool xRayVision, bool spandex, string weaponChoice, string superPower)
        {
            this.xRayVision = xRayVision;
            this.weaponChoice = weaponChoice;
        }

        public SuperHero(bool spandex, string superPower)
        {
            this.spandex = spandex;
            this.superPower = superPower;
        }

        public void StrengthLevel()
        {
            if (spandex)
            {
                Console.WriteLine("Superhero is super strong");
            }
            else
            {
                Console.WriteLine("Only superheroes who wear spandex are super strong");
            }
        }

        public void PowerBoost()
        {
            if (weaponChoice == "gun")
            {
                Console.WriteLine("Superhero gets new advanced tech");
            }
            if (weaponChoice == "hands")
            {
                Console.WriteLine("Superhero eats energy bar");
            }
        }
    }
}
