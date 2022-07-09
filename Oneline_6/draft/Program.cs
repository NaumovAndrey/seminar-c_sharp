int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Ввежите длину массива: ");
int size = Console.ReadLine();
Console.WriteLine("Ввежите min значение массива: ");
int min = Console.ReadLine();
Console.WriteLine("Ввежите max значение массива: ");
int max = Console.ReadLine();