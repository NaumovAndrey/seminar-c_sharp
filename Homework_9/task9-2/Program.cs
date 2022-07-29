/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int input(string num) {
    Console.Write(num);
    return int.Parse(Console.ReadLine());
}
int[] CreateList(int m, int n) 
    {
        List<int> numbers = new List<int>();
        while (m <= n)
        {
            numbers.Add(m);
            m += 1;
        }
        return numbers.ToArray();
    }
int Sum(int[] myArray, int i = 0) { 
    if (i >= myArray.Length) return 0;
    int result = Sum(myArray, i+1);
    return myArray[i] + result;
}

int m = input("Введите начальное число: ");
int n = input("Введите конечное число: ");
int[] array = CreateList(m, n);
int result = Sum(array);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {result}");