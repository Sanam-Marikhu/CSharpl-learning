using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_08
{
    internal class PrintEven
    {

        static void even(int[] a)
        {
            Console.WriteLine("Even Array Elements:");           
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Size Of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
           
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Element " + (i + 1)+": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            even(array);
        }

    }
}
