using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_05
{
    internal class Reverse_triangle
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i =1; i <= 3; i++)
            {
                for (j = 3; j >= i; j--)
                {
                    Console.Write(j+"");
                }
                Console.WriteLine();
            }
        }
    }
}
