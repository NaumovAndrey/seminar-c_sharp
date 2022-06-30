//Работа с текстом. Заменить все пробелы нижним подчёркиваием и поменять регистр буквы к на К, а С на с

string text = "Работа с текстом. Заменить все пробелы нижним подчёркиваием и поменять регистр буквы к на К, а С на с";

string replace(string text, char old, char new){
    string result = string.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i]) == old) result += $"{new};
        else {result += $"{text[i]}";
    }
    return result;
}

string newText = replace(text, ' ', '_');
Console.WriteLine(newText);