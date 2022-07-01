/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
3432 -> да*/

class Program
{
    static int numbers(string us_n)
    {
        Console.WriteLine(us_n);
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

    static void print_no()
    {
        Console.WriteLine("NO");
    }
    static void print_yes(int[] oddm)
    {
        List<int> odd_revers = new List<int>();
        odd_revers() = oddm();
        odd_revers.Reverse();
        bool temp = true;
        for (int i = 0; i < oddm.Length; i++)
        {
            if (oddm[i] != odd_revers[i])
            {
                temp = false;
                break;
            }
         }
        if (temp == false)
        {
            Console.WriteLine("No");
        }
        else Console.WriteLine("Yes");
    }

    static void Main(string[] args)
    {
        int us_num = numbers("enter a number: ");
        int[] oddM = odd(us_num);
         Console.WriteLine(oddM.Count); // счётчик колличества, ещё не реалицован
        print_yes(oddM());
    }
}