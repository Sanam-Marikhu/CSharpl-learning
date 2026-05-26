using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class select
    {
        static void Main(string[] args)
        {
            int [] num = {1, 2, 3, 4, 5, 6};
            var square=num.Select(x => x * x);
            Console.WriteLine("Squared Elements:");
            foreach(var i in square)
            {
                Console.WriteLine(i);
            }


        }
    }
}
