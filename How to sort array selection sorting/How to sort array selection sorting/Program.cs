using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sorting
{
    class Program
    {
        static void insertionMethod(int[] arr1, int x)
        {
            int i, j;

            for(i = 1; i < x; i++)
            {
                int a = arr1[i];
                int b = 0;

                for(j = i - 1; j >= 0 && b != 1;)
                {
                    if(a < arr1[j])
                    {
                        arr1[j + 1] = arr1[j];
                        j--;

                        arr1[j + 1] = a;
                    }
                    else
                    {
                        b = 1;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10] {6, 89, 32, -5, 0, 67, 43, 78, 91, 10};
            int i;

            Console.Write("The original array is: ");
            for(i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }

            insertionMethod(arr, 10);

            Console.Write("\nThe sorted array: ");
            for(i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
