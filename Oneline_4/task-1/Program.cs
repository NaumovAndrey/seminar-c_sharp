/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.
*/

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
int FindPositiveSum(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >0)  sum += Array[i];
    }
    return sum;
}

int[] MyArray = CreateRandomArray(10, 1, 9);
ShowArray(MyArray);
Console.WriteLine("Sum = " + FindPositiveSum(MyArray));