using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30
{
    class MyObject
    {
        public void Run()
        {
            
            string[] data = new string[] { "One", "Two", "Three" };

            
            MyOtherObject otherObj = new MyOtherObject(data);

            
            otherObj.Dispose();
        }
    }
}
