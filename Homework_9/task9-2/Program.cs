/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int input(string num) {
    Console.Write(num);
    return int.Parse(Console.ReadLine());
}
int Sum(int m, int n, int i = 0) { 
    if (m > n) {
        i += (m++);
        return Sum(m, n);
    }
    else return 1;
}

int m = input("Введите начальное число: ");
int n = input("Введите конечное число: ");
int sum = Sum(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {sum}");