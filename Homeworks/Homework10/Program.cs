using System.ComponentModel.DataAnnotations;

namespace Homework10
{
    internal class Program
    {
        private static void TestCarFunctionality(Vehicle car)
        {

            car.GetSpeed();
           
            car.Accelerate(50);
            car.GetSpeed();
            car.Brake(30);
            car.GetSpeed();
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            BMW BMWCar = new BMW();
            TestCarFunctionality(BMWCar);
            BMWCar.PrintInterfaceComponents();

            Console.WriteLine();

            Audi audiCar = new Audi();
            TestCarFunctionality(audiCar);
            audiCar.PrintInterfaceComponents();

            Console.WriteLine();

            Mclaren MclarenCar = new Mclaren();
            TestCarFunctionality(MclarenCar);
            MclarenCar.PrintInterfaceComponents();
        }
    }
}