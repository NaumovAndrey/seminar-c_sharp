/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
3432 -> да*/

class Program
{
    static int numbers(string us_n)
    {
        Console.Write(us_n);
        string t_num = Console.ReadLine();
        int num = Convert.ToInt32(t_num);
        return num;
    }
    static int[] odd(int num)
    {
        num = Math.Abs(num);
        List<int> numbers = new List<int>();
        while (num > 0)
        {
            numbers.Add(num % 10);
            num /= 10;
        }
        numbers.Reverse();
        return numbers.ToArray();
    }
    static int[] oddR(int num)
    {
        num = Math.Abs(num);
        List<int> numbers = new List<int>();
        while (num > 0)
        {
            numbers.Add(num % 10);
            num /= 10;
        }
        return numbers.ToArray();
    }
    static void print(int[] oddm, int[] oddr)
    {
        bool temp = true;
        for (int i = 0; i < oddm.Length; i++)
        {
            if (oddm[i] != oddr[i])
            {
                temp = false;
                break;
            }
         }
        if (temp == false)
        {
            Console.WriteLine("NO");
        }
        else Console.WriteLine("Yes");
    }
    static void Main(string[] args)
    {
        int us_num = numbers("Enter a number: ");   // обращение к методу, ввод с склавиатуры
        int[] oddM = odd(us_num);                   // обращение к методу, расбиваю число на состовляющие
        int[] oddr = oddR(us_num);                  // обращение к методу, тоже самое, тольео в обратном порядке. Незнаю как переварачивать лист, приходится дублировать метод. Потеря времени!
        int count = oddr.Length;                    // подсчет количества элементов в массиве
        if (count % 2 == 1)                         // если не четное, идём дальше иначе выход
        {
            print(oddM, oddr);
        }
        else Console.WriteLine("A number cannot be a palindrome");
    }
}