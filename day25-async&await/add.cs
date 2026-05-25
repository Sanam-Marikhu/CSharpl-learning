using System;
using System.Threading.Tasks;

namespace day28
{
    internal class ReturnAsync
    {
        static async Task<int> Add()
        {
            await Task.Delay(1000);

            return 5 + 8;
        }

        static async Task Main(string[] args)
        {
            int sum = await Add();

            Console.WriteLine("SUM: " + sum);
        }
    }
}