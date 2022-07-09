/*  Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2   */

int userNum(string num)
{
    Console.Write(num);
    string text = Console.ReadLine();
    int nums = Convert.ToInt32(text);
    return nums;
}
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) { array[i] = new Random().Next(100, 1000); }
    return array;
}
int positive_numbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) { counter += 1;}
    return counter;
}
string ShowArray(int[] array)
{
    string mas = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) { mas = mas + array[i]; }
        else { mas = mas + array[i] + ", "; }
    }
    return mas;
}

int num = userNum("Введите длину массива: ");
int[] Array = CreateRandomArray(num);
int counter = positive_numbers(Array);
string mas = ShowArray(Array);
Console.WriteLine("В массиве: [" + mas + "] " + counter + " положительных числа!");

