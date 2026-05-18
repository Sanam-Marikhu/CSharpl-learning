using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 3, 4, 6, 0, 12, 14, 5 };
            var even = array.Where(a => a % 2==0);
            Console.WriteLine("Array Elements: ");
            foreach(var a in array)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Even Numbers:");
            foreach (var e in even)
            {
                Console.Write(e+" ");
            }
        }
    }
}
