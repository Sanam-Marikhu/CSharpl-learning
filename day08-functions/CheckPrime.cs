using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_08
{
    internal class CheckPrime
    {
        static bool Isprime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            
            
                return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be cecked:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is Prime?:"+Isprime(n));
            

        }
    }
}
