/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int checking_for_a_number(string t_num)
{
    bool text_num = int.TryParse(t_num, out int num);
    if (text_num)
    {
        return num;
    }
    else
    {
        return -1;
    }
}
int[] number_length(int num) 
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

Console.Write("Введите число: ");
string t_num = Console.ReadLine();

if (checking_for_a_number(t_num) == -1)
{
    Console.WriteLine("Некоректные данные");
}
else
{
    int num = checking_for_a_number(t_num); 
    int[] num3 = number_length(num);        
    if (num3.Length > 2)
        Console.WriteLine(num3[2]);
    else 
        Console.WriteLine("Третьей цифры нет");
}