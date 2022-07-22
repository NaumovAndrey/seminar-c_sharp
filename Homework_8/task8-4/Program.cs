/*Заполните спирально массив n на m.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/


// Ещё не работает, вылазию за пределы массива (Index was outside the bounds of the array.)третий день думаю :)

void Print(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SpiralArray() {
    int num = 4;
    
    int[,] spiralArray = new int[num, num];
    for (int i = 0; i < num / 2; i++) { 
        for (int j = i; j < num - 1; j++) spiralArray[i, j] = num++; 
        for (int k = i + 1; k < num - i; k++) spiralArray[k, num - i -1] = num++;
        for (int j = num - i - 2; j >= i; j--) spiralArray[num - i - 1, j] = num++;
        for (int k = num - i - 2; k >= i; k--) spiralArray[k, i] = num++;
    }
    return spiralArray;
 } 


int[,] spiralArray = SpiralArray();
Print(spiralArray);