using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    class Student
    {
        public string name;
        public int roll;
        public void Display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Roll:"+ roll);
        }
    }
    internal class Object
    {
        static void Main(string[] args)
        {
            Student st1=new Student();
            st1.name = "Sanam Marikhu";
            st1.roll = 20;
            st1.Display();
            Student st2=new Student();
            st2.name = "Suman Adhikari";
            st2.roll = 30;
            st2.Display();
        }
    }
}
