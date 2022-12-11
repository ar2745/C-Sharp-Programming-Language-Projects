using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Structures
{
    struct Company
    {
        private string name;
        private string position;
        private string car;
        private int salary;
        private int age;

        public void details(string n, string p, string c, int s, int a)
        {
            name = n;
            position = p;
            car = c;
            salary = s;
            age = a;
        }

        public void getDetails()
        {
            Console.WriteLine("The name of the Employee is: {0}", name);
            Console.WriteLine("The position of the Employee is: {0}", position);
            Console.WriteLine("The car of the Employee is: {0}", car);
            Console.WriteLine("The salary of the Employee is: {0}", salary);
            Console.WriteLine("The age of the Employee is: {0}", age);
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Company Employee = new Company();

            Employee.details("Peter Paul", "C# Developer", "Honda", 120000, 24);
            Employee.getDetails();

            Console.ReadKey();
        }
    }
}
