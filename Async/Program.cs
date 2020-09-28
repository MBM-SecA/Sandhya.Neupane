using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main()
        {
            // Making Breakfast

            // Make Tea
            // -Turn on burner(2s)
            // - Place Kettle on burner(3s)
            // - Pour water (5s)
            // - Let it boil (5min)
            // - Grind malasas (1min)
            // - Put sugar and masalas
            // - Pour milk(5s)
            // - Let it boil(3min)

            // - Turn on burner(2s)
            // - Put pan on and oil it(30s)
            // - Crack eggs and whisk it(3min)
            // - Fry(3min)

            
            HttpClient client = new HttpClient();
            Stopwatch stopwatch = Stopwatch.StartNew();
            var google = client.GetStringAsync("https://www.google.com/").Result;
            var micro = client.GetStringAsync("https://www.microsoft.com").Result;
            var yahoo = client.GetStringAsync("https://www.yahoo.com").Result;
            var github = client.GetStringAsync("https://www.github.com").Result;
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            var g = await client.GetStringAsync("https://www.google.com/");
            var m = await client.GetStringAsync("https://www.microsoft.com");
            var y = await client.GetStringAsync("https://www.yahoo.com");
            var gi = await client.GetStringAsync("https://www.github.com");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

        }
    }
}
