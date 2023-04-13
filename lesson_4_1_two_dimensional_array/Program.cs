
string[,] table = new string[2, 5];
table[1, 2] = "word";

for (int row = 0; row < table.GetLength(0); row++)
{
    for (int columns = 0; columns < table.GetLength(1); columns++)
    {
        Console.Write($" -{table[row, columns]}-");
    }
Console.WriteLine();
}

