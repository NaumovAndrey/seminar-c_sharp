/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double UserNum(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
Double[] IntersectionsLines(double b1, double k1, double b2, double k2)
{
    double[] doubles = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    doubles[0] = x;
    double y = k2 * x + b2;
    doubles[1] = y;
    return doubles;
}
void ShowArray(double[] array)
{
    string mas = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) { mas = mas + array[i]; }
        else { mas = mas + array[i] + " "; }
    }
    Console.WriteLine(mas);
}

double b1 = UserNum("b1: ");
double k1 = UserNum("k1: ");
double b2 = UserNum("b2: ");
double k2 = UserNum("k2: ");
double[] xy = IntersectionsLines(b1, k1, b2, k2);
ShowArray(xy);

// без проверок прямых