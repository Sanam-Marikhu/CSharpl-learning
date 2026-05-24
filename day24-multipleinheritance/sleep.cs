using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace day24
{
    internal class sleep
    {
        static void Print()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t=new Thread(Print);
            t.Start();
            Console.WriteLine("Printing numbers after every 1 second");

        }
    }
}
