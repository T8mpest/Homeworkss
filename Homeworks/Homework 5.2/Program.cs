
int[] numbers = { 1, 2, 3, 4, 5, 43, 8, 11 };
Console.WriteLine("Не отзеркаленный массив:");
PrintArray(numbers);
Console.WriteLine();    
Console.WriteLine("Отзеркаленный массив:");
for  (int i = numbers.Length - 1; i >= 0; i--)
{
    //Console.Write(numbers[i] + " ");
    PrintArray(numbers[i]);
}


static void PrintArray(int[] numbers )
{
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
}
Console.ReadLine();