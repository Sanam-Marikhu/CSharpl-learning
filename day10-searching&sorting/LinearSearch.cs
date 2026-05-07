using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 50, 27, 11, 36, 90, 25, 0 };
            Console.Write("Enter the number you want to search: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool c = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("Found at index "+i);
                    c = true;
                    break;
                }

            }
            if (c == true)
            {
                Console.WriteLine("Entered Number is present in list.");
            }

            else
            {
                Console.WriteLine("Entered number is not present in list.");
            }

        }
    }

}
