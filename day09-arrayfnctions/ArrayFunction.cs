using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09
{
    internal class ArrayFunction
    {
        static void Sum(int[]s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            { 
                sum+= s[i];
            }
            Console.WriteLine("Sum of array elements is:" + sum);

        }
        static void Max(int[] m) 
        {
            int max = m[0];
            for (int i = 1; i < m.Length; i++)
            {
                if (max < m[i])
                {
                    max= m[i];
                }
            }
            Console.WriteLine("Max Element:" + max);
        }

        static void CountEvenOdd(int[] e)
        {
            int counteven = 0;
            int countodd= 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] % 2 == 0)
                {
                    counteven++;
                }
                else
                    countodd++;
            }
            Console.WriteLine("Even Count:" + counteven);
            Console.WriteLine("Odd Count:"+ countodd);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int size=Convert.ToInt32(Console.ReadLine());
            int[]arr=new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter element "+(i + 1)+" :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sum(arr);
            Max(arr);
            CountEvenOdd(arr);
        }
    }
}
