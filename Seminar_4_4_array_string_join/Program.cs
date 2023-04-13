int[] array = GenerateArray(12);
PrintArray(array);

int[] GenerateArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}