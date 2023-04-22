// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// использовать dictionary

int[,] table = new int[3, 3];
FillArray(table);
Console.WriteLine("Исходный массив");
PrintArray(table);
Dictionary <int, int> result = FrequencyElementsDictionary(table);
foreach(var row in result)
{
    Console.WriteLine($"key: {row.Key}  value: {row.Value}");
}
// частотный словарь элементов двумерного массива
Dictionary <int, int> FrequencyElementsDictionary(int[,] table)
{
    Dictionary <int, int> frequencyElements = new Dictionary<int, int>();
   
        for (int rows = 0; rows < table.GetLength(0); rows++)
        {
            for (int columns = 0; columns < table.GetLength(1); columns++)
            {
                if (frequencyElements.ContainsKey(table[rows, columns]))
                {
                    frequencyElements[table[rows, columns]] += 1;
                }
                else
                {
                    frequencyElements.Add(table[rows, columns], +1);
                    // Console.WriteLine("Value added for key = \"ht\": {0}", frequencyElements[frequencyElements[table[rows, columns]]]); 
                    //Console.WriteLine(frequencyElements[table[columns, rows]] );
                }
            }
        }
    return frequencyElements;
}
// вывод массива
void PrintArray(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        Console.Write($"строка {rows} - ");
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($" '{table[rows, columns]}'");
        }
        Console.WriteLine();
    }
}
// Заполнение массива случайными числами
void FillArray(int[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++)
        {
         
            
            tab[rows, columns] = new Random().Next(-10, 10);
        }
        Console.WriteLine();
    }
}