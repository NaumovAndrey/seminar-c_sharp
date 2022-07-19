/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] Array() {
    int line = new Random().Next(4, 5);
    int column = new Random().Next(4, 5);
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) { array[i, j] = new Random().Next(1, 10); }
    return array;
}
void Print(int[,] array) {
    int[,] ints = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < ints.GetLength(0); i++) { 
        for (int j = 0; j < ints.GetLength(1); j++) { Console.Write(array[i, j] + " ");}
        Console.WriteLine();
    }
}
int[,] ArrangeValues(int[,] arrayValues) {
    for (int i = 0; i < arrayValues.GetLength(0); i++){
        for (int j = 0; j < arrayValues.GetLength(1); j++) {
            for (int k = 0; k < arrayValues.GetLength(1) - 1; k++) {
                if (arrayValues[i, k] > arrayValues[i, k + 1]) { 
                    int temp = arrayValues[i, k + 1];
                    arrayValues[i, k + 1] = arrayValues[i, k];
                    arrayValues[i, k] = temp;
                }
            }
        }
    }
    return arrayValues;
}

int[,] newArray = Array();
Print(newArray);
int[,] arrangeValues = ArrangeValues(newArray);
Console.WriteLine();
Print(arrangeValues);

//Вопрос! Почему если 43ю строку поставить после 45й. На выводе два массива уже отсортированные?
//(имена же переменных разные, которые идут на печать)