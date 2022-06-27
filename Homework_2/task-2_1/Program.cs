/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

class Program
{
    static int num(string user_num)
    {
        Console.Write(user_num);
        string str = Console.ReadLine();
        int u_num = Convert.ToInt32(str);
 
        return u_num;
    }
    static int[] number_length(int num) 
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
    static void printLackOfData()
    {
        Console.WriteLine("Третьей цифры нет");
    }
    static void printIncorrectData()
    {
        Console.WriteLine("Некорректный ввод");
    }

    static void Main(string[] args) {
        try {
            int user_input = num("Введите положительное целое число: ");
            int[] number_processing = number_length(user_input);
            Console.WriteLine(number_processing[2]); 
        }
        catch (IndexOutOfRangeException) {              
            printLackOfData();
        }
        catch (Exception) {
            printIncorrectData();
        }
    }
}