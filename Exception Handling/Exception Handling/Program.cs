using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main (string[] args)
        {
            try { 
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is: {0}", num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter only integers please");
            }
            Console.ReadKey();
        }
    }
}
