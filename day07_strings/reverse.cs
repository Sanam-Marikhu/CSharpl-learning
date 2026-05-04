using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class reverse
    {
        static void Main(string[] args)
        {
            string reverse = "";
            Console.Write("Enter Text To Reverse: ");
            string txt=Console.ReadLine();
            if (!string.IsNullOrEmpty(txt))
            {
                for (int i=txt.Length-1; i>=0; i++)
                {
                    reverse += txt[i];
                }
                Console.Write(reverse);
            }
            else
            {
                Console.WriteLine("No text Entered");
            }
        }
    }
}
