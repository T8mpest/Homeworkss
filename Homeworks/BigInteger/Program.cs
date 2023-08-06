namespace BigInteger;
using BigInteger;

class Program
{
    static void Main(string[] args)
    {
        LargeNumber num1 = new LargeNumber("12345678901234567890");
        LargeNumber num2 = new LargeNumber("98765432109876543210");

        Console.WriteLine("Initial Numbers:");
        Console.WriteLine("Num1: " + num1);
        Console.WriteLine("Num2: " + num2);

        num1.Add(num2);
        Console.WriteLine("\nAfter Addition:");
        Console.WriteLine("Num1 + Num2: " + num1);

        num1.Subtract(new LargeNumber("11111111111111111111"));
        Console.WriteLine("\nAfter Subtraction:");
        Console.WriteLine("12345678901234567890 - 11111111111111111111 = " + num1);
        Console.ReadLine();
    }
}
