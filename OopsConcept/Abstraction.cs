using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public abstract class Employee 
    {
        public string name;
        public abstract void GetSalary();
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Employee name is:" + name);
        }
    }
    public class ParttimeEmployee:Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("56000");
        }
    }
}
