using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_08
{
    internal class ReturnSum
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static double Sumdouble(double x, double y)
        {
            return x + y;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of th numbers is:" + Sum(a, b));
            Console.WriteLine("Enter Two Decimal Numbers:");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum of the decimal numbers is:" + umdouble(c,d));


        }

    }
}