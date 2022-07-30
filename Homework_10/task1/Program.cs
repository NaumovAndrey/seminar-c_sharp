// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1


string[] TextArray(string text) {
    Console.WriteLine(text);
    string userText = Console.ReadLine();
    string[] userTextArray = userText.Split(new char[] { ' ' }); 
    return userTextArray;
}
int numberOfWords(string[] textArray, int count = 0) { 
    char[] simbol = new char[] {'a', 'e', 'i', 'o', 'u', 'y'};
    for (int i = 0; i < textArray.Length; i++) {
        for (int j = 0; j < simbol.Length; j++) {
            if (textArray[i].ToLower()[0] == char.ToLower(simbol[j])) {
            count++;
            }
        }
    }
    return count;
}

string[] text = TextArray("Введите текст для подсчета слов начинающихся на гласную букву: ");
int count = numberOfWords(text);
Console.WriteLine($"В данном тексте содержится {count} слов начинающихся на гласную букву");