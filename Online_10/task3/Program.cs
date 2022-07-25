// Написать программу, принимающую на вход два массива строк и генерирующую новый массив,
// состоящий из попарно объединенных исходных элементов

int word(string[] array) { 
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length > 2) count++;
    return count;
}

string[] names = {Andrey, Denis, Iv, Dmitrij};
string[] names = {Andrey12, Denis34, Iv56, Dmitrij45};
Console.WriteLine(word(names));