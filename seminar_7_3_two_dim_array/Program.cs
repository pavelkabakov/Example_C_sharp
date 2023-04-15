// Задача 51: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] table = new int[3, 4];
table[0, 0] = 1; table[0, 1] = 4; table[0, 2] = 7; table[0, 3] = 2;
table[1, 0] = 5; table[1, 1] = 9; table[1, 2] = 2; table[1, 3] = 3;
table[2, 0] = 8; table[2, 1] = 4; table[2, 2] = 2; table[2, 3] = 4;


Console.Clear();
// FillArray(table); // заполняем массив
PrintArray(table); // выводим массив
ChangeNumberArray(table);
Console.WriteLine();
PrintArray(table); // выводим массив

void ChangeNumberArray (int[,] table) // заменяем ячейку с четными индексами на квадрат
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        if ( rows%2 == 0)
        {
            for (int columns = 0; columns < table.GetLength(1); columns++)
            {
                if ( columns%2 == 0)
                {
                   table[rows, columns] = table[rows, columns] * table[rows, columns];
                }
            }
        }
    }
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