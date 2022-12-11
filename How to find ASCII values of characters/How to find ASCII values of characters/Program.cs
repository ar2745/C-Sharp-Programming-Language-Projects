using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_ASCII_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Enter any character: ");
            ch = Char.Parse(Console.ReadLine());

            Console.WriteLine("The value of the ASCII character is: {0}", (int)ch);
        }
    }
}
