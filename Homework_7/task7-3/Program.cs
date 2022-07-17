/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int meaningLines, meaningColumns;
int line = new Random().Next(3, 4);
int column = new Random().Next(3, 4);
int[,] data = new int[line, column];
for (int i = 0; i < data.GetLength(0); i++) {
    for (int j = 0; j < data.GetLength(1); j++){ 
        data[i, j] = new Random().Next(1, 10);
        Console.Write(data[i, j] + " ");
    }
    Console.WriteLine();
}
double[] sum = new double[data.GetLength(0)];
for (int i = 0; i < data.GetLength(0); i++) {
    sum[i] = 0;
    for (int j = 0; j < data.GetLength(1); j++){
        sum[i] += data[j, i];
    }
    Console.Write("[" + Math.Round(sum[i] / data.GetLength(1),2) + "]" + " ");
}