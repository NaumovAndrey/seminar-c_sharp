// метод с циклом while. Принимет значение, возвращает значение:

string metod(int count, string text)
{
    int i = 0;
    string result = string.Empty;   // присваевает пустую строку

    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res = metod(5, "text");
Console.WriteLine(res);