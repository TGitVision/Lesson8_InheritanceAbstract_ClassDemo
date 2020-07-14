using System;

namespace Lesson8_InheritanceAbstract_ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson7_InheritanceAbstract_ClassDemo!");

            Dog myDog = new Dog("Fido", 4, 0, false, true, "Dog Bone");
            myDog.Bark();
            myDog.Eat();
            myDog.Sleep();

        }
    }
}
