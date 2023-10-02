using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Thread
{

    class _3Thread
    {
        private static readonly object lockA = new object();
        private static readonly object lockB = new object();
        private static readonly object lockC = new object();

        static void Main(string[] args)
        {
            Thread threadA = new Thread(PrintA);
            Thread threadB = new Thread(PrintB);
            Thread threadC = new Thread(PrintC);

            threadA.Start();
            threadB.Start();
            threadC.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();

            Console.WriteLine("Program completed.");
        }

        static void PrintA()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (lockA)
                {
                    Console.Write("A");
                    Monitor.Pulse(lockB);
                    Monitor.Wait(lockA);
                }
            }
        }

        static void PrintB()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (lockB)
                {
                    Monitor.Wait(lockB);
                    Console.Write("B");
                    Monitor.Pulse(lockC);
                }
            }
        }

        static void PrintC()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (lockC)
                {
                    Monitor.Wait(lockC);
                    Console.Write("C");
                    Monitor.Pulse(lockA);
                }
            }
        }
    }
}
