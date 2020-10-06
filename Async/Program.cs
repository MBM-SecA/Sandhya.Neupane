using System;
using System.Threading;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main1()
        {

            // TPL - Parallel Programming
            Stopwatch stopwatch = new Stopwatch();

            int[] numbers = { 13, 12, 7, 3, 2, 4 };

            // Sequential implementation
            stopwatch.Start();
            Console.WriteLine("Sequential Execution: ");
            foreach (var num in numbers)
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            }
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");

            // Parallel implementation
            stopwatch.Restart();
            Console.WriteLine("Parallel Execution: ");
            Parallel.ForEach(numbers, num =>
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            });
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");

        }

        static long Factorial(long number)
        {
            Task.Delay(100);
            return 0;
        }


        static void Main2()
        {
            // Making Breakfast

            // Make Tea
            // -Turn on burner(2s)
            // - Place Kettle on burner(3s)
            // - Pour water (5s)
            // - Let it boil (10s)
            // - Grind malasas (1min)
            // - Put sugar and masalas
            // - Pour milk(5s)
            // - Let it boil(3min)

            // - Turn on burner(2s)
            // - Put pan on and oil it(30s)
            // - Crack eggs and whisk it(3min)
            // - Fry(3min)


            Stopwatch stopwatch = new Stopwatch();
            // Async Programming

            stopwatch.Start();
            // Sequential version : Expected completion time = 56sec
            TurnOnBurner();
            PutOnBurner("Kettle");
            Add("Water");
            Boil("Water");
            GrindTeaMasala();
            PutSugarAndMasala();
            Add("Milk");
            Boil("Milk");
            TurnOnBurner();
            PutOnBurner("Pan");
            AddOil();
            WhiskEggs();
            Fry();
            Serve();
            Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }

        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            
            // Async Programming
            stopwatch.Start();

            // Parallel Version: Expected completion time = 56s
            Task turnOnBurner1 = TurnOnBurner();
            Task PutOnKettle = PutOnBurner("Kettle");
            Task addWater = Add("Water");
            Task boilWater = Boil("Water");
            Task grindTeaMasala = GrindTeaMasala();
            Task addSugarAndMasala = PutSugarAndMasala();
            Task addMilk = Add("Milk");
            Task boilMilk = Boil("Milk");
            Task turnOnBurner2 = TurnOnBurner();
            Task putOnPan = PutOnBurner("Pan");
            Task addOil = AddOil();
            Task whiskEggs = WhiskEggs();
            Task fry = Fry();
            Task serve = Serve();

            await turnOnBurner1;
            Console.WriteLine("Turning on gas");

            await PutOnKettle;
            Console.WriteLine("Putting kettle on stove");

            await addWater;
            Console.WriteLine("Adding water on kettle");

            await boilWater;
            Console.WriteLine("Boiling water");

            await gridTeaMasala;
            Console.WriteLine("Grindng masalas");

            await addSugarAndMasala;
            Console.WriteLine("adding sugar and masalas");

            await addMilk;
            Console.WriteLine("Added milk");

            await boilMilk;
            Console.WriteLine("Boiled milk");

            await turnOnBurner2;
            Console.WriteLine("Turned on anothe burner");

            await putOnPan;
            Console.WriteLine("Put pan on burner 2");

            await addOil;
            Console.WriteLine("Added oil on pan");

            await whiskEggs;
            Console.WriteLine("Cracked and mixed eggs");

            await fry;
            Console.WriteLine("Fried eggs");

            await serve;
            Console.WriteLine("Serving");

            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static async Task Serve()
        {
            await Task.Delay(5000);
        }

        private static async Task Fry()
        {
            await Task.Delay(10000);
        }

        private static async Task WhiskEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task AddOil()
        {
            await Task.Delay(2000);
        }

        private static async Task PutSugarAndMasala()
        {
            await Task.Delay(2000);
        }

        private static async Task GrindTeaMasala()
        {
            await Task.Delay(5000);
        }

        private static async Task Boil(string item)
        {
            await Task.Delay(10000);
        }

        private static async Task Add(string item)
        {
            await Task.Delay(2000);
        }

        private static async Task PutOnBurner(string pot)
        {
            await Task.Delay(3000);
        }

        private static async Task TrunOnBurner()
        {
            await Task.Delay(2000);
        }


       


        // HttpClient client = new HttpClient();
        // Stopwatch stopwatch = Stopwatch.StartNew();
        // var google = client.GetStringAsync("https://www.google.com/").Result;
        // var micro = client.GetStringAsync("https://www.microsoft.com").Result;
        // var yahoo = client.GetStringAsync("https://www.yahoo.com").Result;
        // var github = client.GetStringAsync("https://www.github.com").Result;
        // Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

        // stopwatch.Restart();
        // var g = await client.GetStringAsync("https://www.google.com/");
        // var m = await client.GetStringAsync("https://www.microsoft.com");
        // var y = await client.GetStringAsync("https://www.yahoo.com");
        // var gi = await client.GetStringAsync("https://www.github.com");
        // Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");


    }
}
