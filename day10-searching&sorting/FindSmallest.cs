using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class FindSmallest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array:");
            int size=Convert.ToInt32(Console.ReadLine());
            int[]array=new int[size];
            for (int i=0; i<array.Length; i++)
            {
                Console.Write("Enter element "+(i+1)+": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int small = array[0];
            for(int i=1; i < array.Length; i++)
            {
                if (small > array[i])
                {
                    small= array[i];
                }
            }
            Console.WriteLine("Smallest Element= " + small);
        }
    }
}
