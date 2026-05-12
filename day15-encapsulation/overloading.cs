using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    class MathOperation
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b; 
        }
        public double Multiply(double a, int b, int c) 
        {
            return a * b * c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation m = new MathOperation();
            Console.WriteLine("Multiply:" + m.Multiply(2, 3));
            Console.WriteLine("Multiply:" + m.Multiply(5.5, 1.6));
            Console.WriteLine("Multiply:" + m.Multiply(5.2,2, 3));
        }
    }
}
