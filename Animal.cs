using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8_InheritanceAbstract_ClassDemo
{
    class Animal
    {
        #region Properties or Fields

        protected string name;
        protected int numOfLegs;
        protected int numOfArms;
        protected bool isDangerous;
        protected bool isFurry;

        #endregion

        #region Methods

        public void Sleep()
        {
            Console.WriteLine("The " + this.GetType() + " goes to sleep.");
        }

        public void Eat()
        {
            Console.WriteLine("The " + this.GetType() + " enjoys eating.");
        }

        #endregion

    }
}
