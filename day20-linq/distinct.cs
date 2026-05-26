using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class distinct
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 7, 5, 2, 0, 0, 4, 6, 25,21, 5, 4, 21 };
            var unique=num.Distinct();
            Console.WriteLine("Unique Elements:");
            foreach(int i in unique) 
                Console.WriteLine(i);

        }
    }
}
