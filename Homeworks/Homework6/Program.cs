while (true)
{
    Console.Write("Write your N number: ");
    var target = int.Parse(Console.ReadLine());
    var numeric = FindNthPrime(target);
    var condition = IsPrime(target);
    Console.WriteLine($"N-prime number: {numeric}");

    static int FindNthPrime(int n)
    {
        int count = 0;
        int number = 2;

        while (count < n)
        {
            if (IsPrime(number))
            {
                count++;
                if (count == n)
                    return number;
            }
            number++;
        }

        return -1; 
    }

    static bool IsPrime(int val)
    {
        if (val < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(val); i++)
        {
            if (val % i == 0)
                return false;
        }

        return true;
    }
}