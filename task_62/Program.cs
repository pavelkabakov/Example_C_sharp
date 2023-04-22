// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] table = new int[4, 4];
Console.WriteLine("Исходный массив");
PrintArray(table);
FillArraySpiral(table);
Console.WriteLine("Заполненный массив");
PrintArray(table);

// заполнение массива по спирали
void FillArraySpiral(int[,] table)
{
    int number = 1; int row = 0; int col = 0;
    while (number <= table.GetLength(0) * table.GetLength(1))
    {
        table[row, col] = number;
        Console.Write($"длинна массива: {table.GetLength(0)} число :{number} row:{row} col:{col}");
        if (row <= col + 1 && row + col < table.GetLength(0) - 1)
        {
            Console.WriteLine(" - первый");
            ++col;
        }
        else if (row < col && row + col >= table.GetLength(1) - 1)
        {
            Console.WriteLine(" - второй");
            ++row;
        }
        else if (row >= col && row + col > table.GetLength(0) - 1)
        {
           Console.WriteLine(" - третий");
           --col;
        }
        else
        {
            Console.WriteLine(" - четвертый");
            --row;
        }
        ++number;
    }
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

