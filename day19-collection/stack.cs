using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19
{
    internal class stack
    {
   
        static void Main(string[] args)
        {
            Stack <int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(8);
            s.Push(55);
            s.Push(0);
            Console.WriteLine("Elements in Stack:");
            foreach (var x in s)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Top Element:"+ s.Peek());
            Console.WriteLine("Removed:"+s.Pop());
            Console.WriteLine("After pop:");
            foreach(var x in s)
            {
                Console.WriteLine(x);
            }

        }
    }
}
