// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int input_from_the_user()
{
    Console.WriteLine("Введите длину массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    return CreateRandomArray(size, min, max);
}                            // Метод, ввод переменных от пользователя и передача в создание массива
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}  // Метод, созданиемассива
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}                          // Вывод массива в консоль
bool finding_value(int[] us_array, int zn)
{
    bool num = false;
    for (int i = 0; us_array.Length; i++)
    {
        us_array[i] = zn;
        num = true;
        break;
    }
    return num;
}

Console.WriteLine("Введите значение для поиска в массиве: ");
int zn = Console.ReadLine();
int[] us_array = input_from_the_user();
bool num_z = finding_value(us_array, zn);
if (num_z = true) { Console.WriteLine(zn + " yes ");}
else { Console.WriteLine(zn + " no ");}