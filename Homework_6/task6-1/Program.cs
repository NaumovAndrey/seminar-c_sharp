/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write("Введите набор чисел через пробел: ");
string userNumbers = Console.ReadLine();
string[] userString = userNumbers.Split(new Char[] {' '});
int count = 0;
foreach(string item in userString)
{
    int num = int.Parse(item);
    if (num > 0) { count++; }
}
Console.WriteLine($"Введено {count} положительных чисел(а)");
