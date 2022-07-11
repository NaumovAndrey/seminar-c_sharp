double Factorial(int num)
{
    // 0! = 1
    // 1! = 1
    if (num == 1) return 1;
    else return num * Factorial(num - 1);
}

Console.Write("Enter number: ");
string text_user = Console.ReadLine();
Console.WriteLine(Factorial(Convert.ToInt32(text_user)));
