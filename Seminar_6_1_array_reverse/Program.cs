// Задача - реверс массива

int[] arr = new int[]{1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 23};

PrintArray(arr);
Reverse(arr);
PrintArray(arr);
// int[] reversed = Reverse(arr);



void Reverse(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 - i] = tmp;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}