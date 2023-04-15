// Задача 46 - Задайте двумерный массив размером m x n,
// заполненный случайными числами

int[,] table = new int[3, 4];

FillArray(table);
PrintArray(table);

void PrintArray(int[,] tab) 
{
table[1, 2] = 5;

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
        tab[rows, columns] = new Random().Next(10, 100);
    }
Console.WriteLine();
}
}