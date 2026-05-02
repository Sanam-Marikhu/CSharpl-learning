using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_05
{
    internal class pyramid
    {
        static void Main(string[] args)
        {
            int i, j,k=1,l;
            for (i = 1; i <= 4; i++)
            {
                for (l = 1; l <= 4-i; l++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {

                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
