/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Console.WriteLine("Введите размер массива");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}

int[] array = GenerateArray(number);
PrintArray(array);

int[] tmparray = array;

int[] copyarray = ArrayCopyTo(array);
PrintArray(copyarray);

Console.WriteLine(array == copyarray);

Console.WriteLine(array == tmparray);

// Вызываем метод создания массива и его заполнение случайными числами
int[] GenerateArray(int number)
{
    int[] array = new int[number]; // создание массива типа int и размером равным переданному параметру

    Random random = new Random(); // создание переменной типа Random

    for (int i = 0; i< number; i++) // цикл от i до length (размер массива)
    {
        array[i] = random.Next(0, 10); // запись в массив случайного числа
    }

    return array; // возврат массива как результат выполнения метода
}

int[] ArrayCopyTo(int[] array)
{
    int[] copyarray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i] = array[i];
    }
    return copyarray;
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}