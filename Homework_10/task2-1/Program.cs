// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}


string[] TextArray(string text) 
{
    Console.WriteLine(text);
    string userText = Console.ReadLine();
    string[] userTextArray = userText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return userTextArray;
}
string[] Unification(string[] arrayWords) 
{
    List<string> list = new List<string>();
    {
        for (int i = 0; i < arrayWords.Length - 1; i += 2)
        {
            list.Add(arrayWords[i] + arrayWords[i + 1]);
        }
    }
    return list.ToArray();
}
void Print(string[] arrayWords) 
{ 
    for (int i = 0; i < arrayWords.Length; i++) 
    {
        Console.Write(arrayWords[i] + " ");
    }
}
string[] text = TextArray("Ведите текст для генерации объединяя элементов исходного текста попарно: ");
string[] unificationText = Unification(text);
Print(unificationText);