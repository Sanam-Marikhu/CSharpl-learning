using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("Ram");
            array.Add(5.2);
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
