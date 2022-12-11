using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers_of_1s_in_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, count = 0;

            Console.WriteLine("Enter the range of numbers: ");
            x = int.Parse(Console.ReadLine());

            int[] y = new int[x];

            Console.WriteLine("Enter only " + x + " amount of numbers while pressing enter after each entered number");

            for(int i = 0; i < x; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int o in y)
            {
                if(o == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("The number of 1s is: {0}", count);
        }
    }
}
