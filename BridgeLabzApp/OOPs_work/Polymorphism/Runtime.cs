using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Polymorphism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal noise...");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Barking");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows...");
        }
    }
    internal class Runtime
    {
        static void Main(string[] args)
        {
            Animal a;

            a = new Dog();
            a.Speak();   // Dog barks...

            a = new Cat();
            a.Speak();   // Cat meows...
        }
    }
}
