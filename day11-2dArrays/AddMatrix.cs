using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_array
{
    internal class AddMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows for matrix:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns for matrix:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[row, column];
            int[,] arr2 = new int[row, column];
            int[,] sum = new int[row, column];
            Console.WriteLine("Enter elements for first array:");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write("Element[" + (i + 1) + "," + (j + 1) + "]" + ":");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements for second array:");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("Element[" + (i + 1) + "," + (j + 1) + "]" + ":");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i, j];
                }
            }




        }
    }
}
