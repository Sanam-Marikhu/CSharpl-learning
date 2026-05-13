using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16
{
   abstract class Vehicle
    {
         public abstract void start();
        public void Display()
        {
            Console.WriteLine("This is abstract Parent method.");
        }
    } 
    class Car : Vehicle
    {
         public override void start()
        {
            Console.WriteLine("Car Starts");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car c=new Car();
            c.start();
            c.Display();
        }
    }
}
