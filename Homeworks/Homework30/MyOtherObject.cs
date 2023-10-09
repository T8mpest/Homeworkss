using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30
{
    unsafe class MyOtherObject : IDisposable
    {
        private string[] dataArray;

        public MyOtherObject(string[] data)
        {
            dataArray = data;
        }

        public void Dispose()
        {
            
            Console.WriteLine("Number of elements in the array: " + dataArray.Length);

            
            Console.WriteLine("Elements in the array:");
            foreach (var item in dataArray)
            {
                Console.WriteLine(item);
            }

            
            GC.Collect();
            GC.WaitForPendingFinalizers();

            
            Console.WriteLine("MyOtherObject has been deleted.");
        }
    }
}
