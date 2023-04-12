using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
        // Override the method of parent class with same method of child class
    public class Dog:Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
}
