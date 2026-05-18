using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class find
    {
        static void Main (string[] args)
        {
            int[] array = { 0, 7, 3, -9, 55, 36, -45, 25362, 42, 75548, 2563, 0152, -7862, 274, 65, 99999 };
            Console.Write("Element Count:");
            Console.WriteLine(array.Count());
            Console.Write("Max Element:");
            Console.WriteLine(array.Max());
            Console.Write("Min Element:");
            Console.WriteLine(array.Min());
            Console.Write("Total Sum:");
            Console.WriteLine(array.Sum());
        }
    }
}
