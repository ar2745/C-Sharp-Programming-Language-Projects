using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_to_Text_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int[] num = new int[20];

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("The number(s) in word: ");
            num2 = 0;
            num3 = 0;

            while(num1 != 0)
            {
                num2 = num1 % 10;
                num[num3] = num2;
                num3++;
                num1 = num1 / 10;
            }
            num3--;
            
            for(; num3 >= 0; num3--)
            {
                Console.Write(digits[num[num3]] + " ");
            }
        }
    }
}
