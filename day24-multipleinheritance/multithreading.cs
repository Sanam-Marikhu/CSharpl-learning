using System;
using System.Threading;

namespace day24
{
    internal class multithreading
    {
        static void Even()
        {
            Console.WriteLine("Printing Even Number:");
            for (int i = 0; i < 20; i++)
            {
               
               if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Odd()
        {
            Console.WriteLine("Printing Odd Nubers:");
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Thread e = new Thread(Even);
            Thread o= new Thread(Odd);
            e.Start();
            o.Start();

        }
    }
}
