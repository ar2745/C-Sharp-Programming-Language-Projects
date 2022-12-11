using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int len = 0;

            Console.Write("Enter a string: ");
            name = Console.ReadLine();

            foreach(char c in name)
            {
                len += 1;
            }

            Console.WriteLine("The length of the string is: {0}", len);
        }
    }
}
