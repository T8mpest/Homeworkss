using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Classwork
{
    internal class Program
    {
        public static int FindElemnt(object[] array, int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(val))
                {
                    return i;
                }
            }
            return -1;
        }
        public static int FindElemnt(int[] array, int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(val))
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            const int N = 1000000;
            List<int> array1 = new List<int>();
            ArrayList array2 = new ArrayList();


            
            //int[] array1 = new int[N];
            //object[] array2 = new object[N];

            //Random random = new Random();

            //for (int i = 0; i < N; i++)
            //{ 
            //   array1[i] = random.Next();
            //   array2[i] = random.Next();
            //}


            Stopwatch st1 = new Stopwatch();

            st1.Start();
            int number1 = FindElemnt(array1, val:-1);
            st1.Stop();

            Stopwatch st2 = new Stopwatch();
            st2.Start();
            int number2 = FindElemnt(array2, val: -1);
            st2.Stop();
            Console.WriteLine("Int:\t" + st1.Elapsed.TotalMilliseconds);
            Console.WriteLine("Object:\t" + st2.Elapsed.TotalMilliseconds);

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

        }

    }
}