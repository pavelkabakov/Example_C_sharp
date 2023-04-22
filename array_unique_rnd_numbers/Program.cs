// создаем массив и заполняем неповторяющимися случайными числами

int[] array = new int[10];

Random random = new Random();
int randomValue = random.Next(1, 11);
// randomValue = random.Next(0, 10);
// array[0] = randomValue;

Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();

for (int i = 0; i < array.Length; i++)
{
    // Console.WriteLine($"Value added for key = {array[i]}:{keys[array[i]]}");

    while (!uniqueNumbers.ContainsKey(array[i]))
    {
        Console.WriteLine($"------цикл:{i}-----------"); // for tests
        randomValue = random.Next(1, 11);

        if (!uniqueNumbers.ContainsKey(randomValue))
        {
            array[i] = randomValue;
            uniqueNumbers.Add(array[i], 1);
            Console.WriteLine($"- новый ключ - {i}:{array[i]}:rnd-{randomValue}"); // for tests
        }
        else
        {
            Console.WriteLine($"повтор - {i}:{array[i]}:rnd-{randomValue}"); // for tests
            // randomValue = random.Next(0, 12);
            // array[i] = randomValue;
        }
        

    }
    // Console.WriteLine($"дальше ----- {i}:{array[i]}:rnd-{randomValue}");

}

PrintArray(array);

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
           Console.WriteLine($"индекс:{i} значение:{array[i]}");
        }
}

