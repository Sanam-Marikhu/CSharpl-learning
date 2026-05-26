using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_20
{
    internal class groupby
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "Ram",
                "Hari",
                "Rita",
                "Sita"
            };

            var group =
                names.GroupBy(x => x[0]);

            foreach (var g in group)
            {
                Console.WriteLine(
                    "Group: " + g.Key);

                foreach (var n in g)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}

