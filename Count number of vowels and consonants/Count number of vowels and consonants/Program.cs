using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_number_of_vowels_and_Consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, length, vowel = 0, consonant = 0;
            string string1;

            Console.Write("Enter some strings: ");
            string1 = Console.ReadLine();

            length = string1.Length;

            for (x = 0; x < length; x++)
            {
                if (string1[x] == 'a' || string1[x] == 'A' || string1[x] == 'e' || string1[x] == 'E' || string1[x] == 'i' || string1[x] == 'I' || string1[x] == 'o' || string1[x] == 'O' || string1[x] == 'u' || string1[x] == 'U')
                {
                    vowel++;
                }
                else if ((string1[x] >= 'a' && string1[x] <= 'z') || (string1[x] >= 'A' && string1[x] <= 'Z'))
                {
                    consonant++;
                }
            }
            Console.WriteLine("The number of vowels is {0} and the number of consonants is {1}", vowel, consonant);
        }
    }
}
