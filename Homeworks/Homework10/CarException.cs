using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class CarSpeedException : Exception
    {
        public CarSpeedException(string message) : base(message)
        {
        }
    }

}
