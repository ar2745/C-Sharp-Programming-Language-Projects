using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_Triangle 
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            int x, y, z, w;

            for(x = 1; x <= 7; x++)
            {
                for(y = 7; y >= x; y--)
                {
                    Console.Write(" ");
                }

                for(z = 1; z <= x; z++)
                {
                    Console.Write(ch++);
                }
                ch--;

                for(w = 1; w < x; w++)
                { 
                    Console.Write(--ch);
                }
                Console.Write("\n"); 

                ch = 'A'; 
            } 
        }  
    }  
}     
