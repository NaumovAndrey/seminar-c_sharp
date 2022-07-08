/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

class Program
{
    static void Main(string[] args)
    {
        int array_length = 8;
        int[] ints = new int[array_length];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = new Random().Next(1, 100);
            if (i == array_length - 1) Console.Write(ints[i]);
            else Console.Write(ints[i] + ",");
        }
    }
}