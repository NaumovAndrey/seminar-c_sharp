/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] Array(int rous, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rous, columns];
    for (int i = 0; i < rous; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = Math.Round((new Random().Next(minValue, maxValue)) + new Random().NextDouble(),2);
         }
    }
    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter number rous: ");
int numRous = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number colums: ");
int numColums = Convert.ToInt32((Console.ReadLine()));
double[,] usArray = Array(numRous, numColums, 1, 9);
ShowArray(usArray);
