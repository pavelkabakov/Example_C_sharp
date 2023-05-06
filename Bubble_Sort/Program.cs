/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
// Console.WriteLine("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine());
int n = 12;
int[] array = new int[n];

Console.WriteLine("Начальный массив: [" + string.Join(", ", FillArrayRandom(array)) + "]");
Console.WriteLine("Отсортированный массив: [" + string.Join(", ", BubbleSort(array)) + "]");

// buble sort 1
int[] BubbleSort(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
return array;
}

// заполнение массива случайными числами
int[] FillArrayRandom(int[] array)
{
Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        int randomValue = random.Next(0, 100);
        array[i]= randomValue;
    }
return array;
}
// заполнение массива вручную
int [] FillArrayManual(int[] array, int length)
{
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}