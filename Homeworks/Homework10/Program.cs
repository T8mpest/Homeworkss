namespace Homework10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Audi BMWCar = new Audi();
            BMWCar.Accelerate(); 
            BMWCar.Brake(); 
            BMWCar.PrintInterfaceComponents();

            Console.WriteLine();

            Audi audiCar = new Audi();
            audiCar.Accelerate(); 
            audiCar.Brake(); 
            audiCar.PrintInterfaceComponents();

            Console.WriteLine();

            Audi MclarenCar = new Audi();
            MclarenCar.Accelerate(); 
            MclarenCar.Brake(); 
            MclarenCar.PrintInterfaceComponents();
        }
    }
}