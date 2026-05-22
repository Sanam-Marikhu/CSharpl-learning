using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19
{
    internal class queue
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ram");
            queue.Enqueue("Shyam");
            queue.Enqueue("Hari");
            queue.Enqueue("Gita");
            queue.Enqueue("Sita");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First Element:" + queue.Peek());
            Console.WriteLine("Removed:" + queue.Dequeue());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
