// Задача 53: Задайте двумерный массив.
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] table = new int[5, 5];
FillArray(table);
Console.WriteLine("Исходный массив");
PrintArray(table);
int rowNumber1 = 3;
int rowNumber2 = 4;
Console.WriteLine("Замененный массив");
StringReplace(table, rowNumber1, rowNumber2);
PrintArray(table);

// Замена строки массива
void StringReplace(int[ , ] table, int rowNumber1, int rowNumber2)
{
int tmp = 0;
    for (int columns = 0; columns < table.GetLength(1); columns++)
    {
        tmp = table[rowNumber1, columns];
        table[rowNumber1, columns]=table[rowNumber2, columns];
        table[rowNumber2, columns]= tmp;
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