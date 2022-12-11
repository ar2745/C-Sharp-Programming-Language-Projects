using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Numbers_Using_Function
{
    class Program
    {
        public void addition()
        {
            int x, y, sum;

            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = int.Parse(Console.ReadLine());

            sum = x + y;

            Console.WriteLine("The sum of {0} & {1} = {2}", x, y, sum);
        }
        static void Main(string[] args)
        {
            Program addition = new Program();
            addition.addition();
        }
    }
}
