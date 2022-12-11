using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Employees_Data_with_Structure
{
    class Program
    {
        struct Company
        {
            public string name;
            public string occupation;
            public int salary;
        };
        static void Main(string[] args)
        {
            Company Employee;

            Employee.name = "Peter Paul";
            Employee.occupation = "C# Developer";
            Employee.salary = 120000;

            Console.WriteLine("The name of the employee is: {0}", Employee.name);
            Console.WriteLine("The occupation of the employee is: {0}", Employee.occupation);
            Console.WriteLine("The salary of the employee is: {0}", Employee.salary);
        }
    }
}
