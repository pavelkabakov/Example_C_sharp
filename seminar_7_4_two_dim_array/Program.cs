// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечетные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2 5 92 3 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 58129
// 8 42 4
// 25 мин

int[,] table = new int[5, 4];
Console.Clear();
FillArray(table); // заполняем массив
PrintArray(table); // выводим массив
ChangeNumberArray(table);
Console.WriteLine();
PrintArray(table); // выводим массив

void ChangeNumberArray (int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if ( i%2 != 0)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if ( j%2 != 0)
                {
                    table[i, j] = table[i, j] * table[i, j];
                }
            }
        }
    }
}

void PrintArray(int[,] tab) 
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" -{table[rows, columns]}-");
    }
Console.WriteLine();
}
}

void FillArray(int[,] tab)
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[rows, columns] = new Random().Next(0, 100);
    }
Console.WriteLine();
}
}