/*  Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

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
    for (int i = 0; i < size; i++) { array[i] = new Random().Next(1, 10); }
    return array;
}
int sum_odd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1) { sum += array[i];}
    return sum;
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
int sum = sum_odd(Array);
string mas = ShowArray(Array);
Console.WriteLine("В массиве: [" + mas + "] сумму элементов, стоящих на нечётных позициях = " + sum);