/*  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

class Program
{
    static int userNum(string num)
    {
        Console.Write(num);
        string text = Console.ReadLine();
        int nums = Convert.ToInt32(text);
        return nums;
    }
    static int[] arrNum(int num)
    {
        List<int> numbers = new List<int>();
        while (num > 0)
        {
            numbers.Add(num % 10);
            num /= 10;
        }
        numbers.Reverse();
        return numbers.ToArray();
    }
    static int arrSum(int[] sum)
    {
        int count = 0;
        for (int i = 0; i < sum.Length; i++)
        {
            count += sum[i];
        }
        return count;
    }
    static void Main(string[] args)
    {
        try
        {
            int nums = userNum("Введите положительное целое число: ");          // Ввод от пользователя
            int[] arrNumbers = arrNum(nums);                                    // Разбиваем число в список
            int count = arrSum(arrNumbers);                                     // считаем сумму кол элементов списка
            Console.WriteLine("Сумма цифр в числе " + nums + " = " + count);    // Вывод в консоль
        }
        catch (Exception) { Console.WriteLine("Некорректные данные");}          // проверка на ввод корректных данных
    }
}

// Павел объясните, как указывать путь для переменной "nums", если строки 41-43 вынести за пределы "try-catch"
// (выдаёт ошибку CS0103: Имя "nums" не существует в текущем контексте.