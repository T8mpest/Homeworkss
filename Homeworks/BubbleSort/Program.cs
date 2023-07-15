using System.Diagnostics;

namespace BubbleSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = GenerateRandomArray(10000);
            

            Stopwatch stopwatch = new Stopwatch();

            // Generic
            stopwatch.Start();
            GenericBubbleSort<int>.BubbleSort(array1);
            stopwatch.Stop();
            Console.WriteLine("Time with generic type: " + stopwatch.Elapsed.Milliseconds + " Milliseconds");

            // NonGeneric
            stopwatch.Reset();
            stopwatch.Start();
            NonGenericBubbleSort.BubbleSort(array1);
            stopwatch.Stop();
            Console.WriteLine("Time without using generic type: " + stopwatch.Elapsed.Milliseconds + " Milliseconds");
        }
        public static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1000);
            }
            return array;
        }
    }
}