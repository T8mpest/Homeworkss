
int[] numbers = { 1, 2, 3, 4, 5, 43, 8, 11 };
Console.WriteLine("Не отзеркаленный массив:");
PrintArray(numbers);
Console.WriteLine();
Console.ReadLine();
Console.WriteLine("Отзеркаленный массив:");
Reverse(numbers);

static void Reverse(int[] numbers)
{
    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.Write(numbers[i] + " ");
    }

}


static void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
}
Console.ReadLine();