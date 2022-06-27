/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5) Console.Write("Нет");
else if (day == 6 || day == 7) Console.WriteLine("Да");
else Console.WriteLine("Ошибка");
*/


class Program {
    static int num(string user_num)
    {
        Console.Write(user_num);
        string str = Console.ReadLine();
        int u_num = Convert.ToInt32(str);
 
        return u_num;
    }
    static string day(int num) {
        int[] i = {1, 2, 3, 4, 5, 6, 7};
        if ()
    }

    static void Main(string[] args) {
        int uNum = num("Введите номер дня недели: ");
        string str = day(uNum);
        Console.WriteLine("Результат: " + str);
    }
}