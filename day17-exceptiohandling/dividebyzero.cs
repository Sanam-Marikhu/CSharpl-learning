using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two values for division:");
                Console.Write("Enter first values:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second values:");
                int b = Convert.ToInt32(Console.ReadLine());
                int div = a / b;
                Console.Write("Divided value:"+div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
