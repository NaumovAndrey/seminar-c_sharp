//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
//N = 4532 -> 4


int UsNum(int num) { return num / 10 != 0 ? 1 + UsNum(num / 10) : 1; }
int InputNum(string textNum) {
    Console.Write(textNum);
    return int.TryParse(Console.ReadLine(), out int num) ? num : 0;
}
int num = InputNum("Введите число: ");
int countNum = UsNum(num);
Console.WriteLine($"Количество цифр в числе {num} = {countNum}");

