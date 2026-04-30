using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_loops
{
    internal class table
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of which you want table:");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i +"x"+ num+ "="+(i*num));
            }
        }
    }
}
