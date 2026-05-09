using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    class Employee
    {
        public string name;
        public int age;
        public string address;
        public double salary;
        public Employee()
        {

            Console.WriteLine("Default Constructor is called.");
        }
        public Employee(string n,int a,string ad,double s)
        {
            name = n;
            age = a;
            address= ad; 
            salary = s;
        }
        public void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Salary: " + salary);

        }


    }
    internal class Constructor
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1=new Employee("Sanam",23,"Bhaktapur",25000);
            e1.Display();
        }
    }
}
