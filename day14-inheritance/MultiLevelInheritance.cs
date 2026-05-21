using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class Person
    {
        public string name;
        public void DisplayName()
        {
            Console.WriteLine("Name:" + name);
        }
    }
    class Employee:Person
    {
        public double salary;
        public void DisplaySalary()
        {
            Console.WriteLine("Salary:" + salary);
        }

    }
    class Manager : Employee
    {
        public string department;
        public void DisplayDepartment()
        {
            Console.WriteLine("Department:" + department);
        }


    }
    internal class Program
    {
        static void Main()
        {
            Manager r = new Manager();
            r.name = "Ram";
            r.salary = 25000;
            r.department = "IT";
            r.DisplayName();
            r.DisplaySalary();
            r.DisplayDepartment();

        }
    }
}
