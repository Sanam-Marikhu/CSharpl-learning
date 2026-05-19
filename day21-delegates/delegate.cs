using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day21
{
    delegate void Calculation(int a, int b);
    internal class Program
    {
        static void Add (int a,int b)
        {
            Console.WriteLine("SUM:"+( a + b));
        }
        static void Mul (int a,int b) 
        {
            Console.WriteLine("MULTIPLICATION:" + (a * b));
        }
        static void Sub(int a,int b)
        {
            Console.WriteLine("DIFFERENCE:" + (a - b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers which you want to perform different arithmetic operations: ");
            Console.Write("Enter First Number:");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Calculation c = Add;
            c += Mul;
            c+= Sub;
            c(x,y);
        

        }
    }
}
