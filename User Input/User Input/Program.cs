using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class Program
    {
        static void Main (string[] args)
        {
            //First example
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            
            Console.Write("What is your age? ");
            string age = Console.ReadLine();

            Console.Write("What is your phone number? ");
            string phone = Console.ReadLine();

            Console.WriteLine("Your name is " + name + " and your age is " + age + " and your phone number is " + phone);
            
            //Second example
            Console.Write("Enter a first number ");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third number ");
            double num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 * num2 * num3);

            Console.ReadKey();
        }
    }
}
