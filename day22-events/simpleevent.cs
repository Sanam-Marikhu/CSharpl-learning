using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day22
{
    delegate void Notify();
    class Process
    {
        public event Notify Completed;
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            Completed();
        }
    }
    internal class Program
    {
        static void Message()
        {
            Console.WriteLine("Process Completed");
        }
        
        static void Main(string[] args)
        {
            Process p=new Process();
            p.Completed += Message;
            p.StartProcess();

        }
    }
}
