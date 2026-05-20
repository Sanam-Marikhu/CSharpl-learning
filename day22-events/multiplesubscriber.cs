using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day22
{
    delegate void Show();
    class Process
    {
        public event Show Greet;
        public void Message()
        {
            Console.WriteLine("Hello,Welcome to My Code");
            Greet?.Invoke();
        }
    }
    internal class multiplesubscriber
    {
        static void Introduction()
        {
            Console.WriteLine("My name is Ram.");
        }
        static void Complete()
        {
            Console.WriteLine("Code Execution Completed");
        }
        static void Main(string[] args)
        {
            Process p=new Process();
            p.Greet += Introduction;
            p.Greet += Complete;
            p.Message();


        }
    }
}
