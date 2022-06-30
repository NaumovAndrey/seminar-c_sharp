// метод. цикл в цикле (таблица умножения)

for (int i = 2; i < 11; i++)
{
    for (int j = 2; j < 11; j++) 
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
    Console.WriteLine();
}