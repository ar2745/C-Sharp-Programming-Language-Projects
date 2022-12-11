using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, bin1, bin2;
            int[] sum = new int[20];

            Console.Write("Enter first binary number: ");
            bin1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second binary number: ");
            bin2 = int.Parse(Console.ReadLine());

            do
            {
                sum[x++] = (bin1 % 10 + bin2 % 10 + y) % 2;
                y = (bin1 % 10 + bin2 % 10 + y) / 2;
                bin1 = bin1 / 10;
                bin2 = bin2 / 10;

            } while (bin1 > 0 || bin2 > 0);

            if(y > 0)
            {
                sum[x++] = y;
            }
            --x;

            Console.Write("The result of sum of binary numbars: ");

            while(x >= 0)
            {
                Console.Write("{0}", sum[x--]);
            }
        }
    }
}
