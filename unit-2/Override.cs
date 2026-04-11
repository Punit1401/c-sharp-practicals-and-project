// Demonstrate use of virtual and override keywords in C#

using System;

namespace lab_work_1
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Override
    {
        static void Main()
        {
            Animal a = new Animal();
            a.Sound();

            Animal d = new Dog();   // Polymorphism
            d.Sound();

            Console.ReadLine();
        }
    }
}
