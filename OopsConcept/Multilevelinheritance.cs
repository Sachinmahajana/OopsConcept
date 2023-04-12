using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Tractor
    {
        public string brand;
        public string moDel;
        public long price;

        public void TractorInformation()
        {
            Console.WriteLine("Tractor brand is:" + brand);
            Console.WriteLine("Tractor description is:" + moDel);
            Console.WriteLine("Tractor Price is:" + price);
        }
    }
    public class Sonalika:Tractor
    {
        public string colour;
        public void PrintColour()
        {
            Console.WriteLine("Tractor Colour is:" + colour);
        }
    }
    public class JohnDeere:Sonalika
    {
        public int Hp;
        public string description;
         
        public void SpecificDetails()
        {
            Console.WriteLine("Tractor Horsepower is:" + Hp);
            Console.WriteLine("Tractor model is:" + description);
        }
    }
}
