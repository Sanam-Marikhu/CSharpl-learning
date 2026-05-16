using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class append
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("data.txt", true);
                sw.WriteLine("I am curretly learning dotnet programming language.");
                sw.Close();
                Console.WriteLine("Data Appended Sucessfully.");
                if (File.Exists("datas.txt"))
                {
                    StreamReader sr = new StreamReader("data.txt");
                    string line;
                     while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
