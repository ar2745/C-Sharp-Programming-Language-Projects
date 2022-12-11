using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabets_Digits_and_Special_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = 0, alphabet = 0, special = 0, x, length;
            string str1;

            Console.Write("Enter some strings: ");
            str1 = Console.ReadLine();
            length = str1.Length;

            for (x = 0; x < length; x++)
            {
                if ((str1[x] >= 'a' && str1[x] <= 'z' || str1[x] >= 'A' && str1[x] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str1[x] >= '0' && str1[x] <= '9')
                {
                    digits++;
                }
                else
                {
                    special++;
                }
                x++;
            }
            Console.WriteLine("The number of Alphabet is {0}, and digits is {1} and special character is {2}", alphabet, digits, special);
        }
    }
}
