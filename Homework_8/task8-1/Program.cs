/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2     1 5 8 5     1 20 56 10
5 9 2 3 (*) 4 9 4 2 (=) 20 81 8 6
8 4 2 4     7 2 2 6     56 8 4 24
5 2 6 7     2 3 4 7     10 6 24 49
*/

int[,] CreateArray() {
    int rous = 5;
    int columns = 5;
    int[,] array = new int[rous, columns];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) { array[i, j] = new Random().Next(1, 10); }
    }
    return array;
}
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) { Console.Write(array[i, j] + " ");}
        Console.WriteLine();
    }
}
int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] array = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++) {
        for (int j = 0; j < matrixTwo.GetLength(1); j++){
            array[i, j] = matrixOne[i, j] * matrixTwo[i, j];
        }
    }
    return array;
}

int[,] matrixOne = CreateArray();
int[,] matrixTwo = CreateArray();
int[,] composition = MatrixMultiplication(matrixOne, matrixTwo);

Print(matrixOne);
Console.WriteLine();
Print(matrixTwo);
Console.WriteLine();
Print(composition);

// как сделать, если будут 2 не одинаковых массива (где есть значения перемножаются, а где отсутствуют пусто или ошибка), а надо 0?