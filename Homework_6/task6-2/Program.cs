/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double UserNum(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
Double IntersectionsLines(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double b1 = UserNum("Введите первую точку прямой AB: ");
double k1 = UserNum("Введите вторую точку прямой AB: ");
double b2 = UserNum("Введите первую точку прямой CD: ");
double k2 = UserNum("Введите вторую точку прямой CD: ");
double x = IntersectionsLines(b1, k1, b2, k2);
Console.WriteLine(x);

