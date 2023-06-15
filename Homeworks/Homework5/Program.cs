while (true) 
{
    int[] numbers = { 1, 4, 7, 2, 8, 6, 3 };
    Console.WriteLine("Введите число которое хотите найти");
    int target = int.Parse(Console.ReadLine());
    int pos = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        { pos = i;
            break;
        }
    }
    if (pos != -1)
    {
        Console.WriteLine($"{target} Найдено на позиции {pos}");
    }
    else
    {
        Console.WriteLine($"{target} Не найдено в массиве, попробуйте еще раз");
    }
}