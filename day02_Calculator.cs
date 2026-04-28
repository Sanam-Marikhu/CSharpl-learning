using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_practice
{
    internal class day02_Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum = " + (num1 + num2));
            Console.WriteLine("Difference = " + (num1 - num2));
            Console.WriteLine("Product = " + (num1 * num2));
            Console.WriteLine("Quotient = " + (num1 / num2));
        }
    }
}
