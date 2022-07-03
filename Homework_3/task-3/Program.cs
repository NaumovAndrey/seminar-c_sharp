//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

class Program
{
    static int numbers(string tNum)
    {
        Console.Write(tNum);
        string text = Console.ReadLine();
        int num = int.Parse(text);
        return num;
    }
    static void kub(int num)
    {
        Console.Write("Числа от 1 до " + num + " в третьей степени: ");
        for (int i = 1; i <= num; i++)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
    }
    static void Main(string[] args)
    {
        int us_num = numbers("Введите число: ");
        kub(us_num);
    }
}