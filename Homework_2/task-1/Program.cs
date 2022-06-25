﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int second_index(int nums)                               // метод. вычислям среднюю цифру
{
    int result = (nums / 10) % 10;                       // записываем результат входных данных в переменную 'result'
    return result;                                       // выходные данные 
}


while (true) 
{
    Console.WriteLine("Введите трёхзначное число: ");    // запрос на ввод трёхзначного числа
    string text = Console.ReadLine();                    // ввод от пользователя
    bool text_num = int.TryParse(text, out int num);     // проверяем ввод на число, если истина, значит конвертируем в int и записываем в переменную num
    if (text_num)
    {
        if (num < 1000 && num > 99)                      // проверяем число на трёхзначное
        {
            int res = second_index(num);                 // обращаемся к методу 'second_index'
            Console.WriteLine(res);                      // и конечно же выводим в консоль
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