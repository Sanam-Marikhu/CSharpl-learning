using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07
{
    internal class count_vowel
    {
        static void Main(string[] args)
        {
            int vowel_count = 0;
            Console.WriteLine("Enter text to count vowels letters:");
            string text=Console.ReadLine();
            if(!string.IsNullOrEmpty(text) )
            {
                for(int i = 0; i < text.Length; i++)
                {
                    char ch = char.ToLower(text[i]);
                    if (ch=='a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowel_count++;
                    }
                }
                Console.WriteLine("Total no of vowel letters are: "+vowel_count);
            }
        }
    }
}
