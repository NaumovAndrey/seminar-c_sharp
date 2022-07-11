string[,] table = new string[2, 5];  // Создан массив из двух строк и пяти столбцов
// интексы начинаются с ноля.
table[1, 3] = "text";   // присвоено значение text 2 строка 4 столбец

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($" *{table[i, j]}");
    }
    Console.WriteLine();
}