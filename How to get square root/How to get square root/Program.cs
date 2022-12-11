using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            double sqrnum = Math.Sqrt(num);

            Console.WriteLine("The square root of " + num + " is: {0}", sqrnum);
        }
    }
}
