using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class greater
    {
        static void Main(string[] args)
        {
            int [] array = { 4, 0, 85, 69, 142, 35, -56, 85, 3, 4, 9 };
            var arr=array.Where(x => x > 25);
            Console.WriteLine("Array Elements: ");
            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Numbers Greater Than 25:");
            foreach (var e in arr)
            {
                Console.Write(e + " ");
            }

        }
    }
}
