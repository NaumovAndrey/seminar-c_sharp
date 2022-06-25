/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int second_index(int nums)
{
    int result = (nums / 10) % 10;
    return result;
}


while (true) 
{
    Console.WriteLine("Введите трёхзначное число: ");    // запрос на ввод трёхзначного числа
    string text = Console.ReadLine();
    bool text_num = int.TryParse(text, out int num);
    if (text_num)
    {
        if (num < 1000 && num > 99)
        {
            int res = second_index(num);
            Console.WriteLine(res);
            break;
        }
            
        else 
            Console.WriteLine("Введены некоректные данные. Число может быть в диапозоне от 100 до 999");
    }
    else
    {
        Console.WriteLine("Введены некоректные данные. Введите данные согласно условию задачи!");
    }
}