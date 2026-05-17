using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace day19
{
    internal class genericlist
    {
        static void Main(string[] args)
        {
            List<int> num=new List<int>();
            Console.WriteLine("Enter five numbers:");
            for (int i = 0; i <5; i++)
            {
                Console.Write("Element" + (i+1) +":");
                int a=Convert.ToInt32(Console.ReadLine());
                num.Add(a);
            }
            Console.WriteLine("List Elements:");
            for (int i = 0;i <num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }
            num.Sort();
            Console.WriteLine("Sorted List Elements:");
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
