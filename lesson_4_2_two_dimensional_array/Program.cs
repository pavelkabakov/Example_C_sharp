
int[,] table = new int[2, 5];

PrintArray(table);
FillArray(table);
PrintArray(table);

void PrintArray(int[,] tab)
{
table[1, 2] = 5;

for (int row = 0; row < tab.GetLength(0); row++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" -{table[row, columns]}-");
    }
Console.WriteLine();
}
}

void FillArray(int[,] tab)
{
table[1, 2] = 5;

for (int row = 0; row < tab.GetLength(0); row++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[row, columns] = new Random().Next(1, 10);
    }
Console.WriteLine();
}
}