using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_loops
{
    internal class print_even
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write("Enter number up to which you want to print even numbers:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (i <= num)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }
    }
}
