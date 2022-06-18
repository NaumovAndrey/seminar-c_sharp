int n1, n2, quad;

Console.Write("Ведите число 1: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите число 1: ");
n2 = Convert.ToInt32(Console.ReadLine());

quad = n2 * n2;

if (quad == n1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}