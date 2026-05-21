using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class count_digit
    {
        static void Main(string[] args)
        {
            int digit_count = 0;
            Console.Write("Enter text with digits: ");
            string text=Console.ReadLine();
            if(!string.IsNullOrEmpty(text) )
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char ch = char.ToLower(text[i]);
                    if(char.IsDigit(ch))
                    {
                        digit_count++;
                    }
                }
                Console.WriteLine("Total no of digits in text is: "+ digit_count);
            }
            else
            {
                Console.WriteLine("No Text Entered");
            }
        }
    }
}
