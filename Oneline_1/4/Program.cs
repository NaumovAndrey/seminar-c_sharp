Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num *= -1;
}

int current = num * (-1);

while (current < num + 1)
{
    Console.Write(current + " ");
    current++;
}