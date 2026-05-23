using System;

namespace day23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> mul = 
                (a, b) => a * b;
            Console.WriteLine("Multiplication:" + mul(4, 8));
        }
    }
}
