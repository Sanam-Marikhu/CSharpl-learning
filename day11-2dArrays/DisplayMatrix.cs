using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_array
{
    internal class DisplayMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no of rows for matrix:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of columns for matrix:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr= new int[row, column];
            for(int i = 0; i <arr.GetLength(0); i++)
            {
                for(int j = 0; j <arr.GetLength(1); j++)
                {
                    Console.Write("Element[" + (i+1) + "," + (j+1) + "]"+":");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array Elements:");
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
