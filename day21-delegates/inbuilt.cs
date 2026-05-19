using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day21
{
    internal class inbuilt
    {
        static void Message()
        {
            Console.WriteLine("Welcome Dear!");
        }
        static int Add(int x, int y)
        {
            return x + y;

        }
        static void Main(string[] args)
        {
            Action a = Message;
            a();
            Func<int, int, int> f = Add;
            Console.WriteLine("SUM:"+f(8,9));
        }
    }
}
