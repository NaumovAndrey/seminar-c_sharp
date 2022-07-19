// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumNum(int n) {
    if (n >= 10) {
        return n % 10 +SumNum(n/10);
    }
    else {return n ;}
}
Console.WriteLine(SumNum(1234));