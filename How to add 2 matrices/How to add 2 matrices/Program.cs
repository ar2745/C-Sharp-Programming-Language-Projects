using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of_Two_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[100, 100];
            int[,] arr2 = new int[100, 100];
            int[,] arr3 = new int[100, 100];
            int i, j, x;

            Console.Write("Enter the size of square matrix(less than 5): ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter the elements of the first matrix: ");
            for(i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    Console.Write("Index - [{0}, {1}]: ", i, j);
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter the elements of the second matrix: ");
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    Console.Write("Index - [{0}, {1}]: ", i, j);
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\n The first matrix: ");
            for(i = 0; i < x; i++)
            {
                Console.Write("\n");
                for(j = 0; j < x; j++)
                {
                    Console.Write("{0} \t", arr1[i, j]);
                }
            }

            Console.Write("\n The second matrix: ");
            for (i = 0; i < x; i++)
            {
                Console.Write("\n");
                for (j = 0; j < x; j++)
                {
                    Console.Write("{0} \t", arr2[i, j]);
                }
            }

            for(i = 0; i < x; i++)
            {
                for(j = 0; j < x; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            Console.Write("\n The addition of matrices is: ");
            for(i = 0; i < x; i++)
            {
                Console.Write("\n");
                for(j = 0; j < x; j++)
                {
                    Console.Write("{0} \t", arr3[i, j]);
                }
            }
        }
    }
}
