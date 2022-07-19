// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.


double Stepen(double n, double b) {
    if (b > 0) {
        return n * Stepen(n, b - 1);
    }
    else if (b < 0) {
        return (1/n)*Stepen(n, b + 1);
    }
    else {return 1 ;}
}
Console.WriteLine(Stepen(2, -3));