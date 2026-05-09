using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class Program
    {
        public class Car
        {
           public string brand;
           public string model;
        }
        static void Main(string[] args)
        {
           Car c1=new Car();
            c1.brand = "Tesla";
            c1.model = "Teslav5";
            Console.WriteLine("Car Brand=" + c1.brand);
            Console.WriteLine("Car Model=" + c1.model);
        }
   

    } 
}
