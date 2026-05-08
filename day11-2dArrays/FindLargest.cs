using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_array
{
    internal class FindLargest
    { static void Main(string[] args)
        {
            Console.Write("Enter number of rows for matrix:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns for matrix:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[row, column];
            Console.WriteLine("Enter elements for array:");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write("Element[" + (i + 1) + "," + (j + 1) + "]" + ":");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int max = arr1[0, 0];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for(int j = 0;j < arr1.GetLength(1); j++)
                {
                    if(arr1[i, j] > max)
                    {
                        max=arr1[i, j];
                    }
                }
            }
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Largest Element from above matrix is: " + max);
        }
    }
}
