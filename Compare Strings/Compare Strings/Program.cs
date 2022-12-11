using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Peter is good";
            string lastName = "Paul is best";

            if(String.Compare(firstName, lastName) == 0)
            {
                Console.WriteLine(firstName + " and " + lastName + " are equal");
            }
            else
            {
                Console.WriteLine(firstName + " and " + lastName + " are not equal");
            }
            Console.ReadKey();
        }
    }
}
