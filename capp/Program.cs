using System;
using System.Threading.Tasks;

namespace CounterApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int limit = int.MaxValue;
            if(args.Length > 0)
            {
                limit = int.Parse(args[0]);
            }
            int counter = 1;
            while(true)
            {
                Console.WriteLine(counter);
                counter++;
                await Task.Delay(1000);
            }
        }
    }
}
