using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 9, 0, 2, 5, -1, 2, 4, -9, 6, 4, 8, 5, 2 };
            int x;

            Console.WriteLine("The original array is: ");
            foreach(int arr in arr1)
            {
                Console.Write(arr + " ");
            }

            for(int y = 0; y <= arr1.Length - 2; y++)
            {
                for(int z = 0; z <= arr1.Length - 2; z++)
                {
                    if (arr1[z] > arr1[z + 1])
                    {
                        x = arr1[z + 1];
                        arr1[z + 1] = arr1[z];
                        arr1[z] = x;
                    }
                }
            }            
            Console.WriteLine("\nThe sorted array is: ");
            foreach(int arr in arr1)
            {
                Console.Write(arr + " ");
            }
        }
    }
}
