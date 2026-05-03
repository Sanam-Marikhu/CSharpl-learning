using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06
{
    internal class counteven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements is " + sum);
            Console.ReadLine();
        }
    }
}
