//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2Array(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++) { newArray[i, j] = new Random().Next(minValue, maxValue + 1); }
        return newArray;
}
void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(i, j + " ");
        }
        Console.WriteLine();
    }
}
int m = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2Array(m,n, 1, 9);
Show2Array(myArray);