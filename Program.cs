using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat;
            //cat.Speak();
            animal.Speak();

            Duck duck = new Duck();
            animal = duck;
            //duck.Speak();
            animal.Speak();

            Tiger tiger = new Tiger();
            animal = tiger;
            //tiger.Speak();
            animal.Speak();

            Console.ReadLine();
        }
    }
}