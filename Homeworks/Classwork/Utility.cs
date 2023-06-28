using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    internal class Utility
    {

        public static bool IsInteger(string str)
        {
            foreach (var c in str)
            {
                if (c > '9' || c < '0')
                {
                    return false;
                }
            }
            return true;
        }
        //public static bool IsPrime(int number)
        //{
        //    for (int i = 2; i < Math.Sqrt(number); i++)
        //    {

        //    }
        //}
    }
    }
