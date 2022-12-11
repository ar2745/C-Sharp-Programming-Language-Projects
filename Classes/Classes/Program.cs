using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Company
    {
        public string name;
        public string position;
        public int age;
        public int salary;
    }
    class Triangle
    {
        public double tbase;
        public double height;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company Employee = new Company();
            Triangle triangle = new Triangle(); 

            Employee.name = "Peter Paul";
            Employee.position = "C# Developer";
            Employee.age = 24;
            Employee.salary = 120000;

            Console.WriteLine("The name of the employee is: {0}", Employee.name);
            Console.WriteLine("The position of the employee is: {0}", Employee.position);
            Console.WriteLine("The age of the employee is: {0}", Employee.age);
            Console.WriteLine("The salary of the employee is: {0}", Employee.salary);

            Console.WriteLine("\n");

            triangle.tbase = 4.6;
            triangle.height = 8.9;

            double Area = 0.5 * triangle.tbase * triangle.height;

            Console.WriteLine("The area of the triangle is: {0}", Area);

            Console.ReadKey();
        }
    }
}
