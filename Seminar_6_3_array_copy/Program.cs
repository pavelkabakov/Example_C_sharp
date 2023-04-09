// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] arr = new int[]{1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 23};
int[] arr2 = new int[arr.Length];

Console.WriteLine("Массив 1 до копирования");
PrintArray(arr);
Console.WriteLine("Массив 2 до копирования");
PrintArray(arr2);
CopyArray(arr, arr2);
Console.WriteLine("Массив 2 после копирования");
PrintArray(arr2);

Console.WriteLine(arr == arr2);

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void CopyArray(int[] array1, int[] array2)
{
        for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
}