// Задача 53: Задайте двумерный массив.
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] table = new int[5, 5];
FillArray(table);
Console.WriteLine("Исходный массив");
PrintArray(table);
int string1 = 0;
int string2 = 4;
Console.WriteLine("Замененный массив");
StringReplace(string1, string2, table);
PrintArray(table);

// Замена строки массива
void StringReplace(int string1Number, int string2Number, int[ , ] table)
{
int tmp = 0;
    for (int columns = 0; columns < table.GetLength(1); columns++)
    {
        tmp = table[string1Number, columns];
        table[string1Number, columns]=table[string2Number, columns];
        table[string2Number, columns]= tmp;
    }
}
// вывод массива
void PrintArray(int[,] tab) 
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    Console.Write($"строка {rows} - ");
    for (int columns = 0; columns < tab.GetLength(1); columns++)
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