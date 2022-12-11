using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Vowels_and_Consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;

            Console.Write("Enter a character: ");
            c = Char.Parse(Console.ReadLine());

            if(c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
            {
                Console.WriteLine("This character '{0}' is a vowel", c);
            } 
            else
            {
                Console.WriteLine("This character '{0}' is a consonant", c);
            }
        }
    }
}
