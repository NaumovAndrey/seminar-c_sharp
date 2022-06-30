//метод. возвращает, но ничего не принимает:

int metod()
{
    return DateTime.Now.Year;
}

int year = metod();
Console.WriteLine(year);