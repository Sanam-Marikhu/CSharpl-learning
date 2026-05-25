using System;
using System.Threading.Tasks;

namespace day28
{
    internal class MultipleTasks
    {
        static async Task Task1()
        {
            await Task.Delay(1000);

            Console.WriteLine("Task 1 Completed");
        }

        static async Task Task2()
        {
            await Task.Delay(2000);

            Console.WriteLine("Task 2 Completed");
        }

        static async Task Main(string[] args)
        {
            Task t1 = Task1();

            Task t2 = Task2();

            await t1;
            await t2;

            Console.WriteLine("All Tasks Finished");
        }
    }
}