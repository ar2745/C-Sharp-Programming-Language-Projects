using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Company
    {
        public string name;
        public string position;
        public string car;
        public int salary;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company Employee;

            Employee.name = "Peter Paul";
            Employee.position = "C# Developer";
            Employee.car = "Honda";
            Employee.salary = 120000;
            Employee.age = 24;

            Console.WriteLine("Employee name is {0}", Employee.name);
            Console.WriteLine("Employee position is {0}", Employee.position);
            Console.WriteLine("Employee car is {0}", Employee.car);
            Console.WriteLine("Employee salary is {0}", Employee.salary);
            Console.WriteLine("Employye age is {0}", Employee.age);

            Console.ReadKey();
        }
    }
}
