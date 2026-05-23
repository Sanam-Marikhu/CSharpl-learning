using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace day23
{
    delegate void Message();
    internal class anonomousmethod
    {
        static void Main(string[] args)
        {
            Message m = delegate ()
            {
                Console.WriteLine("This is anonomous method");
            };
            m();

        }
    }
}
