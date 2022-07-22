/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] NewArray() {
    int line = new Random().Next(2, 10);
    int col = new Random().Next(2, 10);
    int[,] array = new int[line, col];
    for (int i = 0; i < line; i++) {
        for (int j = 0; j < col; j++) {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void Print(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " ");
        } Console.WriteLine();
    }
}
int MinLineArray(int[,] array) {
    int[] ints = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            sum += array[i, j];
        }
        ints[i] = sum;
        sum = 0;
    }
    int indexMinSum = 0;
    int num = ints[0];
    for (int k = 1; k < ints.Length; k++) {
        int temp = ints[k];
        if (num > temp) { 
            num = temp;
            indexMinSum = k + 1;
        }
    }
    return indexMinSum;
}

int[,] array = NewArray();
Print(array);
int minLine = MinLineArray(array);
Console.WriteLine(minLine  + " cтрока наименьшая в массиве");