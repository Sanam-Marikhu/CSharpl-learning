using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class fileinformation
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo("data.txt");
            Console.WriteLine("File Name:"+f.Name);
            Console.WriteLine("File Size:" + f.Length);
            Console.WriteLine("Created At:" + f.CreationTime);
        }
    }
}
