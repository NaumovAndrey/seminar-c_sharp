// метод. принимает значение(я), ничего не возвращает

void metod(string text)
{
    global::System.Console.WriteLine(text);
}

metod("message");

void metodvoid(string text, int count)
{
    int i = 0;
    while (i < count)
    {
        global::System.Console.WriteLine(text);
        i++;
    }
}

metodvoid("message", 4);
metodvoid(text: "message", count: 4);//тоже самое, только именнованое