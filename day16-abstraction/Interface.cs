using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16
{ 
    interface Area
    {
        double Area(double x, double y);
    }
    interface Cost
    {
        double Cost(double x);
    }

    class Plot : Area, Cost
    {
        public double Area(double x, double y) 
        {
            return x * y;
        }
        public double Cost(double x) 
        {
            return x ; 
        }
        public void TotalCost(double length,double breadth,double cost)
        {
           double total = Area(length,breadth) * Cost(cost);
            Console.WriteLine("The Total Cost of Plot is :"+total);

        }
    }
    internal class Interface
    {
        static void Main(string[] args)
        {
            Plot p=new Plot();
            p.TotalCost(45,55.36,85.65);

        }
    }
}
