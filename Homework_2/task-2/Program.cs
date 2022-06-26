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
 // num = Math.Abs(num);
    List<int> numbers = new List<int>();
    while (num > 0)
    {
        numbers.Add(num % 10);
        num /= 10;
    }
    numbers.Reverse();
    return numbers.ToArray();
 
}
void print()
{
    Console.WriteLine("Некорректные данные");
}

Console.Write("Введите положительное целое число: ");
string t_num = Console.ReadLine();

if (checking_for_a_number(t_num) == -1)
{
    print();
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

/*
 Павел подскажите, (предполагаю не корректности написания)
делаю проверку на ввод числа в методе "checking_for_a_number", если ложь возвращает "-1" 
и мне приходится основной код загонять в условие. Как лучьше воспользоваться "-1" или вобще делать проверку не через TryParse?

и можно в методе ссылаться на другой метод?

По задаче работает но много "НО" 
описать в цикл при вводе одго и двух значного числа и некорректности ввода(символов), чтобы выдовал заного ввод
 */