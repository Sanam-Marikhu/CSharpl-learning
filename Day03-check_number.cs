using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Conditions
{
    internal class check_number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 && num % 2 == 0)
            {
                Console.WriteLine("Entered number is negative even");
            }
            else if (num < 0 && num % 2 != 0)
            {
                Console.WriteLine("Entered number is negative odd");
            }
            else if (num > 0 && num % 2 == 0)
            {
                Console.WriteLine("Entered number is postive even");
            }
            else if (num > 0 && num % 2 != 0)
            {
                Console.WriteLine("Entered number is positive odd");
            }

            else
            {
                Console.WriteLine("Entered number is Zero.");
            }
        }
    }
}
