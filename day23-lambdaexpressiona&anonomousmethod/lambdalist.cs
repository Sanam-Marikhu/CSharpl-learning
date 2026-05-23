using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day23
{
    internal class lambdalist
    {
        static void Main(string[] args)
        {
            List<int>num=new List<int>() { 5,8,6,0,4,9,11};
            var even = num.Where(x => x % 2 == 0);
            var odd=num.Where(x=>x%2!=0);
            Console.WriteLine("Even Elements:");
            foreach(int i in even)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Odd Elements:");
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }
    }
}
