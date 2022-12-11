using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Structure
{
    class Program
    {
        struct Company 
        {
            public string name;
            public string occupation;
            public string salary;
            public DOB Date;
        };

        struct DOB
        {
            public int day;
            public int month;
            public int year;
        };
        static void Main(string[] args)
        {
            int result = 1, day = 0, month = 0, year = 0;
            string name = "0";

            Company[] Employee = new Company[result];

            for (int x = 0; x < result; x++)
            {
                Console.Write("Enter name of employee: ");
                name = Console.ReadLine();
                Employee[x].name = name;

                Console.Write("Enter day of birth: ");
                day = Convert.ToInt32(Console.ReadLine());
                Employee[x].Date.day = day;

                Console.Write("Enter month of birth: ");
                month = Convert.ToInt32(Console.ReadLine());
                Employee[x].Date.month = month;

                Console.Write("Enter year of birth: ");
                year = Convert.ToInt32(Console.ReadLine());
                Employee[x].Date.year = year;
            }

                Console.WriteLine("The name of the employee is: {0}", name);
                Console.WriteLine("The date of birth of the employee is: {0}/{1}/{2}", month, day, year);            
        }
    }
}
