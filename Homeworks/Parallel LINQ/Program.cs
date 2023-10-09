namespace Parallel_LINQ
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 100000000).ToArray();


            int threadCount = args.Length > 0 ? int.Parse(args[0]) : Environment.ProcessorCount;

            Console.WriteLine($"Using {threadCount} thread(s) for processing...");


            var stopwatchPLINQ = Stopwatch.StartNew();

            var resultPLINQ = numbers.AsParallel()
                                    .WithDegreeOfParallelism(threadCount)
                                    .Where(x => x % 2 == 0)
                                    .Select(x => x * x)
                                    .ToList();

            stopwatchPLINQ.Stop();

            Console.WriteLine("PLINQ processing:");
            Console.WriteLine("Result count: " + resultPLINQ.Count);
            Console.WriteLine("Time taken: " + stopwatchPLINQ.ElapsedMilliseconds + " ms");
            Console.WriteLine();

            var stopwatchLINQ = Stopwatch.StartNew();

            var resultLINQ = numbers.Where(x => x % 2 == 0)
                                    .Select(x => x * x)
                                    .ToList();

            stopwatchLINQ.Stop();

            Console.WriteLine("LINQ processing:");
            Console.WriteLine("Result count: " + resultLINQ.Count);
            Console.WriteLine("Time taken: " + stopwatchLINQ.ElapsedMilliseconds + " ms");
        }
    }
}