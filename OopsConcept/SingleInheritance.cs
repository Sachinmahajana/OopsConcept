using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Car
    {
        public string model;
        public string colour;
        public long price;
        public void PrintCarDetails()
        {
            Console.WriteLine("Car model is: " + model);
            Console.WriteLine("Car colour is:" + colour);
            Console.WriteLine("Car price is:" + price);
        }
    }
    public class Mghector:Car
    {
        public float mileage;
        public void PrintMileage()
        {
            Console.WriteLine("Car mileage is:" + mileage);
        }

    }
}
