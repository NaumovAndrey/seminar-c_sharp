/*  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int userNum(string num)
{
    Console.Write(num);
    string text = Console.ReadLine();
    int nums = Convert.ToInt32(text);
    return nums;
}
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++) { array[i] = Math.Round((new Random().Next(1, 10)) + new Random().NextDouble(),2); }
    return array;
}
double difference(double[] array)
{
    double min, max;
    min = double.MaxValue; max = double.MinValue;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] < min) { min = array[i]; }    
        if (array[i] > max) { max = array[i]; }
    }
    return max - min;
}
string ShowArray(double[] array)
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
double[] Array = CreateRandomArray(num);
double Difference = difference(Array);
string mas = ShowArray(Array);
Console.WriteLine("В массиве: [" + mas + "] разница максимального и минимального числа = " + Difference);
