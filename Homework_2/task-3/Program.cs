/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

class Program 
{
    static int u_num(string t_num)
    {
        Console.WriteLine(t_num);
        string str = Console.ReadLine();
        int num = Convert.ToInt32(str);
        return num;
    }
    static void calculation(int usnum)
    {
        if (usnum < 6 && usnum > 0)
        {
            Console.WriteLine("NO");
        }
        else if (usnum < 8 && usnum > 5)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("Enter a number from 1 to 7");
        }
    }
    static void Main(string[] args)
    {
        int usnum = u_num("Введите номер дня недели: ");
        calculation(usnum);
    }
}