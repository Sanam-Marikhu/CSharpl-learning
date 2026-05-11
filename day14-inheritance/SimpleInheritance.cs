using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;
            public void Display()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Age:" + age);
            }
        }
        class Man : Person
        {
            public string address;
            public void Detail()
            {
                Console.WriteLine("Address:"+address);
            }
        
        }
        static void Main(string[] args)
        {
            Man m=new Man();
            m.name = "Ram";
            m.age = 23;
            m.address = "Bhaktapur";
            m.Display();
            m.Detail();
        }
    }
}
