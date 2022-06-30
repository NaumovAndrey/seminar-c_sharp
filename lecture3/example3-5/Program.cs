// метод с циклом for. Принимет значение, возвращает значение:

string metod(int count, string text)
{
    string result = string.Empty;   // присваевает пустую строку

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string res = metod(5, "text");
Console.WriteLine(res);