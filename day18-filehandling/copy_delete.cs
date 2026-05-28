using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class copy_delete
    {
        static void Main(string[] args)
        {
            File.Copy("data.txt", "backup.txt",true);
            Console.WriteLine("File Copied Sucessfully");
            string data=File.ReadAllText("backup.txt");
            Console.WriteLine(data);
            if (File.Exists("backup.txt"))
            {
                File.Delete("backup.txt");
                Console.WriteLine("File Deleted");
            }
        }
    }
}
