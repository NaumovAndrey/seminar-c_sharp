// Написать программу, которая выводит первое встречное слово на заданную букву из массива строк

string Find(string[] words, char cymbol) { 
    for (int i = 0; i < words.Length; i++) {
        if (words[i].ToLower[0] == char.ToLower(cymbol) return words[i];
    }
    return "Empty";
}

string[] names = {Andrey, Denis, Ivan, Dmitrij};
Console.WriteLine(Find(names, 'a'));


// Console.WriteLine(names[2]); // иван
// Console.WriteLine(names[2][2]); //элемент