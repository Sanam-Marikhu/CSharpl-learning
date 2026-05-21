using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array element in ascending order:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array element in descending order:");

            for (int i = arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
