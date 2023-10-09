namespace Task_based_Asynchronous_Pattern
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            int number = 10;


            int threadCount = args.Length > 0 ? int.Parse(args[0]) : 1;

            Console.WriteLine($"Starting calculation using {threadCount} thread(s)...");
            Console.WriteLine();


            var stopwatchSync = Stopwatch.StartNew();
            int syncResult = CalculateSync(number);
            stopwatchSync.Stop();

            Console.WriteLine("Synchronous calculation:");
            Console.WriteLine("Result: " + syncResult);
            Console.WriteLine("Time taken: " + stopwatchSync.ElapsedMilliseconds + " ms");
            Console.WriteLine();

            var stopwatchAsync = Stopwatch.StartNew();
            Task<int> asyncTask = CalculateAsync(number, threadCount);
            int asyncResult = await asyncTask;
            stopwatchAsync.Stop();

            Console.WriteLine("Asynchronous calculation:");
            Console.WriteLine("Result: " + asyncResult);
            Console.WriteLine("Time taken: " + stopwatchAsync.ElapsedMilliseconds + " ms");
        }

        static int CalculateSync(int number)
        {
            return number * number;
        }

        static async Task<int> CalculateAsync(int number, int threadCount)
        {

            //await Task.Delay(1000);

            return await Task.Run(() =>
            {
                Console.WriteLine("Calculating square asynchronously on thread: " + Environment.CurrentManagedThreadId);
                return number * number;
            });
        }
    }
}