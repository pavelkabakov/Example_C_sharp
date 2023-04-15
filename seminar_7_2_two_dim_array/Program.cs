// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4. 0 1 23
// 1 2 34
// 2 3 45

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
        tab[rows, columns] = rows + columns;
    }
Console.WriteLine();
}
}