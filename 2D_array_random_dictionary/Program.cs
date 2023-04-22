// Напишите программу, которая выводит массив из 8 элементов,
// заполненный неповторяющимися двузначными числами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = 8; // задаем длинну массива
int[] array = new int[number];

FillArrayRandom(array);
PrintArray(array);
// Dictionary <int, int> result = FrequencyElementsDictionary(table);
// foreach(var row in result)
// {
//     Console.WriteLine($"key: {row.Key}  value: {row.Value}");
// }

void FillArrayRandom(int[] array)
{
    Random random = new Random();
    int randomValue = random.Next(0, 10);
    Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();

    for (int i = 0; i < array.Length; i++)
    {
    // Console.WriteLine($"Value added for key = {array[i]}:{keys[array[i]]}");
        if (uniqueNumbers.ContainsKey(array[i]))
        {
            Console.WriteLine($"{i}:Повтор");
        }
        else
        {
            randomValue = random.Next(0, 10);
            array[i] = randomValue;
            uniqueNumbers.Add(array[i], 1);
        }
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i}:{array[i]}");
    }
}

