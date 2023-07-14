namespace Homework10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BMW BMWCar = new BMW();
            BMWCar.Accelerate(); 
            BMWCar.Brake(); 
            BMWCar.PrintInterfaceComponents();

            Console.WriteLine();

            Audi audiCar = new Audi();
            audiCar.Accelerate(); 
            audiCar.Brake(); 
            audiCar.PrintInterfaceComponents();

            Console.WriteLine();

            Mclaren MclarenCar = new Mclaren();
            MclarenCar.Accelerate(); 
            MclarenCar.Brake(); 
            MclarenCar.PrintInterfaceComponents();
        }
    }
}