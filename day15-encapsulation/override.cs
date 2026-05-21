using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15
{
    class Vehicle
    {
        public string color;
        public string name;
        public Vehicle(string col, string n)
        {
            this.color = col;
            this.name = n;
        }
        public virtual void Start()
        {
            Console.WriteLine("This is Parent class");
            Console.WriteLine("Name:"+this.name);
            Console.WriteLine("Color:" + this.color);
        }
    }
    class Car : Vehicle 
    {
        public override void Start()
        {
            Console.WriteLine("This is child class");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Red","BYD");
            Car c=new Car();
            c.Start();
            v.Start();
        }
    }
}
