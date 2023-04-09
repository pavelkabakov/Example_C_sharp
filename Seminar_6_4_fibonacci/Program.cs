/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}

int[] array = GenerateArray(number);

PrintArray(array);

int[] GenerateArray(int number)
{
    int[] array = new int[number];

    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            array[i] = 0;
        }
        else if (i == 1)
        {
            array[i] = 1;
        }
        else
        {
            array[i] = array[i-2] + array[i -1];
        }
    }

    return array;
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
