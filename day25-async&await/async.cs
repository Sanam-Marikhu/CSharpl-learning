using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day25
{
    internal class Program
    {
        static async Task Message()
        {
            await Task.Delay(2000);

            Console.WriteLine(
                "Message after 2 seconds");
        }
            static async Task Main(string[] args)
        {
            Console.WriteLine("Program Started");

            await Message();

            Console.WriteLine("Program Ended");
        }
    }
}
