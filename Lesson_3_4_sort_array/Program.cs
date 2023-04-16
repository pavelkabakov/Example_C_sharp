// Сортировка массива

Console.Clear();

int[] arr = { 1, 56, 4, 67, 7, 8, 66, 73, 2, 4, 4, 88, 687 };

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
// вывод массива
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// сортировка одномерного массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                  minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

