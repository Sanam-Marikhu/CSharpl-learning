using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class descending
    {
        static void Main(string[] args)
        {
            int[] array = { -36, 0, 7, 55, -91, 36, 258, 354, 015, 24, 85, 35, -1, 7 };
            var sort = array.OrderByDescending(x => x);
            Console.WriteLine("Array Elements: ");
            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Numbers in ascending order:");
            foreach (var e in sort)
            {
                Console.Write(e + " ");
            }
        }
    }
}
