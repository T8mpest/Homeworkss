namespace Parallel
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 1000000).ToArray();

            
            int numThreads = args.Length > 0 ? int.Parse(args[0]) : Environment.ProcessorCount;

            Console.WriteLine("Using {0} threads.", numThreads);

            
            var sequentialStartTime = DateTime.Now;
            long sequentialSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sequentialSum += Calculate(numbers[i]);
            }

            var sequentialEndTime = DateTime.Now;
            Console.WriteLine("Sequential sum: " + sequentialSum);
            Console.WriteLine("Sequential execution time: " + (sequentialEndTime - sequentialStartTime).TotalMilliseconds + " ms");

            
            var parallelStartTime = DateTime.Now;
            long parallelSum = 0;

            
            Parallel.ForEach(numbers, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, number =>
            {
                parallelSum += Calculate(number);
            });

            var parallelEndTime = DateTime.Now;
            Console.WriteLine("Parallel sum: " + parallelSum);
            Console.WriteLine("Parallel execution time: " + (parallelEndTime - parallelStartTime).TotalMilliseconds + " ms");
        }

        static long Calculate(int number)
        {
            return (long)number * number;
        }
    }

}