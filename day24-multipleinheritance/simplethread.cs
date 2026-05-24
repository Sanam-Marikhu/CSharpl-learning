using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace day24
{
    internal class Program
    {
        static void Print()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Message()
        {
            Console.WriteLine("Child Thread");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Print);
            Thread m= new Thread(Message);
            m.Start();
            t.Start();
            Console.WriteLine("Printing Numbers:");
            Console.WriteLine("Main Thread");
        }
    }
}
