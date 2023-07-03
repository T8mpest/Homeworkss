namespace Homework10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car bmwCar = new BMW();
            bmwCar.GetSpeed();
            bmwCar.Accelerate();
            bmwCar.GetSpeed();
            bmwCar.Brake();
            bmwCar.GetSpeed();

            Console.WriteLine();

            Car audiCar = new Audi();
            audiCar.GetSpeed();
            audiCar.Accelerate();
            audiCar.GetSpeed();
            audiCar.Brake();
            audiCar.GetSpeed();
            
            Console.WriteLine();

            Car mclarenCar = new Mclaren();
            mclarenCar.GetSpeed();
            mclarenCar.Accelerate();
            mclarenCar.GetSpeed();
            mclarenCar.Brake();
            mclarenCar.GetSpeed();
        }
    }
}