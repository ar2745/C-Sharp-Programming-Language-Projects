using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, strfinder;

            Console.Write("Enter some strings: ");
            str1 = Console.ReadLine();

            Console.Write("Enter a string to search: ");
            strfinder = Console.ReadLine();

            int getstr = str1.IndexOf(strfinder);

            if(getstr >= 0)
            {
                Console.WriteLine("String found at index {0}", getstr);
            }
            else
            {
                Console.WriteLine("No substring is found");
            }
        }
    }
}
