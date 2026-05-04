using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class input_print
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Hello " + name);
                Console.WriteLine("Your name letter by letter is:");
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }
            else
            {
                Console.WriteLine("No Name Entered");
            }

        }
    }
}
