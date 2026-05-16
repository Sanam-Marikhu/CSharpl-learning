using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("data.txt");
                sw.WriteLine("My name is Ram.");
                sw.WriteLine("I am from Bhaktapur.");
                sw.Close();

                StreamReader sr = new StreamReader("data.txt");
                string data = sr.ReadToEnd();
                Console.WriteLine(data);
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
