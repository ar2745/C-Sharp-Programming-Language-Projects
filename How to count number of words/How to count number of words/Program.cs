using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Number_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, word;
            string w;

            x = 0;
            word = 1;

            Console.WriteLine("Enter some strings: ");
            w = Console.ReadLine();

            do
            {

                if(w[x] == ' ')
                {
                    word++;
                }
                x++;

            } while (x <= w.Length - 1);

            Console.WriteLine("The number of words are: {0}", word);
        }
    }
}
