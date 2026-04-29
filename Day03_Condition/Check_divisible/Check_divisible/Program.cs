using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Entered number is zero.");
            }
            else
            {
                if (num < 0)
                {
                    if (num % 5 == 0)
                        Console.WriteLine("Negative and divisible by 5.");
                    else
                        Console.WriteLine("Negative number.");
                }
                else
                {
                    if (num % 5 == 0)
                        Console.WriteLine("Positive and divisible by 5.");
                    else
                        Console.WriteLine("Positive number.");
                }
            }
        }
    }
}
