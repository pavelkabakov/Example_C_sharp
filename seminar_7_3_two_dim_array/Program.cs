// Задача 51: Задайте двумерный массив.
// Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] table = new int[3, 4];

Console.Clear();
FillArray(table); // заполняем массив
PrintArray(table); // выводим массив
Console.WriteLine();
Console.WriteLine(GetDiagonalSumm(table));


int GetDiagonalSumm (int[,] table) // ищем сумму диагонали
{
    int summDiagonal = 0;
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
            {
                if ( rows == columns )
                {
                   summDiagonal += table[rows, columns];
                }
            }
    }
    return summDiagonal;
}

void PrintArray(int[,] tab) // вывод массива
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

void FillArray(int[,] tab) // заполнение массива случайными числами
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