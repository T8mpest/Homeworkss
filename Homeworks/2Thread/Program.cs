namespace _2Thread
{
    using System;
    using System.Threading;

    class Program
    {
        private static int count = 1;
        private static readonly object lockObj = new object();

        static void Main(string[] args)
        {
            Thread evenThread = new Thread(PrintEvenNumbers);
            Thread oddThread = new Thread(PrintOddNumbers);

            evenThread.Start();
            oddThread.Start();

            evenThread.Join();
            oddThread.Join();

            Console.WriteLine("Program completed.");
        }

        static void PrintEvenNumbers()
        {
            while (count <= 10)
            {
                lock (lockObj)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine("Even Thread: " + count);
                        count++;
                    }
                }
            }
        }

        static void PrintOddNumbers()
        {
            while (count <= 10)
            {
                lock (lockObj)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine("Odd Thread: " + count);
                        count++;
                    }
                }
            }
        }
    }
}