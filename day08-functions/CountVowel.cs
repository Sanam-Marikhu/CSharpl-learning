using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_08
{
    internal class CountVowel
    {
        
        static void Vowelcount(string txt)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(txt))
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    char c = char.ToLower(txt[i]);
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        count++;
                    }

                }
                Console.WriteLine("Total vowel count:" + count);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a Text:");
            string text=Console.ReadLine();
            Vowelcount(text);

        }
    }
}
