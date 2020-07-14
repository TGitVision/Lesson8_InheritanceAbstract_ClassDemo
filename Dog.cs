using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8_InheritanceAbstract_ClassDemo
{
    class Dog : Animal
    {
        #region Properties or Fields

        private string favoriteChewToy;

        #endregion

        #region Constructors
        public Dog(string name, int numOfLegs, int numOfArms,
            bool isDangerous, bool isFurry, string favoriteChewToy)
        {
            // stuff from our base class, Animal
            this.name = name;
            this.numOfLegs = numOfLegs;
            this.numOfArms = numOfArms;
            this.isDangerous = isDangerous;
            this.isFurry = isFurry;

            // new stuff only our Dog can do...
            this.favoriteChewToy = favoriteChewToy;
        }
        #endregion

        #region Methods
        public void Bark()
        {
            Console.WriteLine("The " + this.GetType() + " goes WOOF WOOF!");
        }
        #endregion

    }

}

