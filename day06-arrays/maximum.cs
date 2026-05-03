using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06
{
    internal class maximum
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
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
            }
            Console.Write("Max value is:" + max);
                
            Console.ReadLine();
        }
    }
}
