// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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
int[] m(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
    return array;
}

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] mas = CreateRandomArray(size, min, max);
Console.Write("Первоначальный массив: ");
ShowArray(mas);
Console.Write("Первоначальный массив * (-1): ");
ShowArray(m(mas));

