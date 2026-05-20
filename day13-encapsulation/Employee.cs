using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    class Employee
    {
        private string name;
        private int age;
        public string Name { get; set; }
        public int Age 
        {
            get {  return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e=new Employee();
            Console.Write("Enter Name:");
            e.Name= Console.ReadLine();
            Console.Write("Enter Age:");
            e.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:"+e.Name);
            Console.WriteLine("Age:" + e.Age);

        }
    }
}
