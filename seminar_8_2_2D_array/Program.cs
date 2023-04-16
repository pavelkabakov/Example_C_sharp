// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] table = new int[6, 5];
FillArray(table);
Console.WriteLine("Исходный массив");
PrintArray(table);
Console.WriteLine("Замененный массив");
PrintArray(ArrayRowsToColumnsReplace(table));

// Замена строк на столбцы в двумерном массиве
int[,] ArrayRowsToColumnsReplace(int[,] table)
{
    int[,] tmpArray = new int[table.GetLength(0), table.GetLength(1)];
    if (ValidateRowsEqColumns(table))
    {
        for (int rows = 0; rows < table.GetLength(0); rows++)
        {
            for (int columns = 0; columns < table.GetLength(1); columns++)
            {
                tmpArray[rows, columns] = table[columns, rows];
            }
        }
    }
    return tmpArray;
}
//Проверка равенства количества строк и столбцов
bool ValidateRowsEqColumns(int[,] table)
{
    if (table.GetLength(0) != table.GetLength(1))
    {
        Console.WriteLine("Число строк не равно числу столбцов");
        return false;
    }
    return true;
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