using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    // Base class
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sound();
        }
    }
}
