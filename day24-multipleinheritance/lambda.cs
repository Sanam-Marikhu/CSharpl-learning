using System;
using System.Threading;

namespace day24
{
    internal class lambda
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() =>
            {
                Console.WriteLine("This is Lambda Expression");
            });
            t.Start();

            }
        }
    }

