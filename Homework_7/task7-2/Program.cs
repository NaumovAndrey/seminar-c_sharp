/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/

// в методе используются магическме числа для упращения читаемости вывода.

void Array(int line, int column) {
    int meaningLine = new Random().Next(3, 10);
    int meaningColumn = new Random().Next(3, 10);
    int[,] array = new int[meaningLine, meaningColumn];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) { 
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (line > meaningLine || column > meaningColumn || line < 1 || column < 1) {
        Console.WriteLine("Такого элемента в массиве нет."); 
    }
    else { Console.WriteLine($"Значение в массиве = {array[line - 1, column - 1]}");}

}


Console.Write("Введите позицию строки в массиве: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Array(line, column);