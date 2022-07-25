//Написать программу, принимающую на вход массив строк и определяющую кол-во слов с длиной не меньше 3 символов

int word(string[] array) { 
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length > 2) count++;
    return count;
}

string[] names = {Andrey, Denis, Iv, Dmitrij};
Console.WriteLine(word(names));